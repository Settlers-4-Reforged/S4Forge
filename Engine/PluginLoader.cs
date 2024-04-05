using DryIoc;

using Forge.Config;
using Forge.Logging;
using Forge.Native;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Forge.Engine {
    internal static class PluginLoader {
        const string PluginExtension = "*.nasi";

        class PluginInfo {
            internal const string ConfigFileName = "plugin.cfg";

            /// <summary>
            /// The name of the plugin.
            /// </summary>
            [JsonPropertyName("name")]
            public required string Name { get; set; }

            /// <summary>
            /// The version of the plugin.
            /// </summary>
            /// <remarks>
            /// Required format: `Major.Minor.Patch` (e.g. `1.0.0`)
            /// </remarks>
            [JsonPropertyName("version")]
            public required string Version { get; set; }

            /// <summary>
            /// If the plugin is enabled or not.
            /// </summary>
            [JsonPropertyName("enabled")]
            public required bool IsEnabled { get; set; }

            /// <summary>
            /// A additional folder with other dll dependencies to add to the library search path.
            /// </summary>
            [JsonPropertyName("library_folder")]
            public string LibraryFolder { get; set; }

            public struct Dependency {
                /// <summary>
                /// The name of the dependency according to it's plugin name.
                /// </summary>
                [JsonPropertyName("name")]
                public required string Name { get; set; }

                /// <summary>
                /// The desired version of the dependency.
                ///
                /// This string can have wildcards, like `1.0.*` or `1.*` to match any such version inside the wildcard range.
                /// </summary>
                [JsonPropertyName("version")]
                public required string Version { get; set; }
            }

            /// <summary>
            /// A list of dependencies that this plugin requires to function
            /// </summary>
            [JsonPropertyName("dependencies")]
            public Dependency[] Dependencies { get; set; } = { };

            public string directory;
        }

        static readonly string PluginDirectory = Path.Combine(Environment.CurrentDirectory + "/plugins/Forge/Plugins");
        const string PluginLibFolder = "lib";

        public static bool LoadAllPlugins(Container dependencies) {
            string[] directories = Directory.GetDirectories(PluginDirectory);
            List<PluginInfo> plugins = new List<PluginInfo>();

            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions {
                ReadCommentHandling = JsonCommentHandling.Skip,
            };

            foreach (string directory in directories) {
                // Check if config file exists
                string configFilePath = Path.Combine(directory, PluginInfo.ConfigFileName);
                if (!File.Exists(configFilePath)) {
                    Logger.LogError(null, $"Plugin '{directory}' is missing a config file.");
                    continue;
                }

                // Load config file
                PluginInfo pluginInfo;
                try {
                    pluginInfo = JsonSerializer.Deserialize<PluginInfo>(File.ReadAllText(configFilePath), jsonSerializerOptions);
                } catch (Exception e) {
                    Logger.LogError(e, $"Error during load of config file '{configFilePath}'");
                    continue;
                }

                pluginInfo.directory = directory;
                plugins.Add(pluginInfo);
            }

            Logger.LogInfo($"Found {plugins.Count} plugin(s) to load.");

            foreach (PluginInfo plugin in plugins) {
                try {
                    string directory = plugin.directory;

                    bool missingDependencies = false;
                    foreach (PluginInfo.Dependency dependency in plugin.Dependencies) {
                        PluginInfo? foundDependency = plugins.FirstOrDefault(p => p.Name == dependency.Name);
                        if (foundDependency == null) {
                            Logger.LogError(null, $"Plugin '{directory}' has a dependency '{dependency.Name}' that does not exist.");
                            missingDependencies = true;
                            break;
                        }

                        string dependencyVersion = dependency.Version;
                        string foundDependencyVersion = foundDependency.Version;

                        // Check if dependency version is in wildcard range
                        if (!CompareVersionsWithWildcard(dependencyVersion, foundDependencyVersion)) {
                            Logger.LogError(null, $"Plugin '{directory}' has a dependency '{dependency.Name}' with an incompatible version.");
                            missingDependencies = true;
                            break;
                        }

                    }

                    if (missingDependencies) {
                        continue;
                    }


                    // Check if plugin assembly exists
                    string[] pluginFiles = Directory.GetFiles(directory, PluginExtension);
                    switch (pluginFiles.Length) {
                        case 0:
                            Logger.LogError(null, $"Plugin '{directory}' is missing a plugin assembly.");
                            continue;
                        case > 1:
                            Logger.LogError(null, $"Plugin '{directory}' has multiple plugin assemblies.");
                            continue;
                    }

                    string pluginFile = pluginFiles[0];

                    Logger.LogInfo($"Loading Plugin '{plugin.Name}'...");

                    AssemblyInitializations.AddFolderLoadSource(directory);
                    AssemblyInitializations.AddFolderLoadSource(Path.Combine(directory, PluginLibFolder));

                    LoadPlugin(dependencies, pluginFile);
                } catch (Exception e) {
                    string stackTrace = e.StackTrace;
                    while (e.InnerException != null) {
                        e = e.InnerException;
                    }

                    Logger.LogError(e, $"Error during load of plugin '{plugin.Name}'");
                }
            }

            InitializeAllPlugins(dependencies);

            return true;
        }

        private static bool CompareVersionsWithWildcard(string requiredVersion, string foundVersion) {
            if (!requiredVersion.Contains("*")) {
                return requiredVersion == foundVersion;
            }

            string[] requiredVersionParts = requiredVersion.Split('.');
            string[] foundVersionParts = foundVersion.Split('.');

            for (int i = 0; i < requiredVersionParts.Length; i++) {
                // Skip wildcard parts
                if (requiredVersionParts[i] == "*") {
                    continue;
                }

                // Check if version parts are equal
                if (foundVersionParts.Length <= i || requiredVersionParts[i] != foundVersionParts[i]) {
                    return false;
                }
            }

            return true;
        }

        private static void LoadPlugin(Container dependencies, string file) {
            string msg = $"Loading Plugin Assembly '{file}'...";
            Logger.LogInfo(msg);

            Assembly pluginAssembly = Assembly.LoadFrom(file);
            AssemblyInitializations.AddAssemblyLoadSource(pluginAssembly);

            var types = new List<Type>(pluginAssembly.GetTypes());

            Type[] pluginTypes = (from Type t in types
                                  where
                                      t.GetInterface(nameof(IPlugin)) != null &&
                                      !t.IsAbstract &&
                                      !t.IsInterface
                                  select t).ToArray();

            if (pluginTypes.Length == 0) {
                Logger.LogError(null, $"Failed to find any valid plugin classes in '{file}'");
                return;
            }

            foreach (Type pluginType in pluginTypes) {
                Logger.LogInfo($"Found Plugin '{pluginType.Name}'");
                dependencies.RegisterMany(new[] { pluginType }, Reuse.Singleton);
            }
        }

        private static void InitializeAllPlugins(Container dependencies) {
            List<IPlugin> plugins = dependencies.ResolveMany<IPlugin>().ToList();
            plugins.Sort((x, y) => x.Priority - y.Priority);

            foreach (IPlugin plugin in plugins) {
                try {
                    string msg =
                        $"Initializing Plugin '{plugin.GetType().Name}' with a priority of {plugin.Priority}...";
                    Logger.LogInfo(msg);
                    plugin.Initialize();
                } catch (Exception e) {
                    string stackTrace = e.StackTrace;
                    while (e.InnerException != null) {
                        e = e.InnerException;
                    }

                    string errorMsg =
                        $"Error during initialization of Plugin '{plugin.GetType().Name}'\nError: {e.Message}\n\n============= Stack Trace =============\n{stackTrace}";
                    Logger.LogError(e, errorMsg);
                }
            }
        }

        public static IEnumerable<Assembly> GetActivePluginAssemblies() {
            return DI.Dependencies.ResolveMany<IPlugin>().Select(plugin => plugin.GetType().Assembly).DistinctBy(assembly => assembly.Location);
        }
    }
}
