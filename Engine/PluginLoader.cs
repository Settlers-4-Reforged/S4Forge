using DryIoc;

using Forge.Config;
using Forge.Logging;
using Forge.Native;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Forge.Engine {
    internal static class PluginLoader {
        /// <summary>
        /// An extension to the ForgeUpdater manifest. Manifest struct is not imported to avoid dependency
        /// </summary>
        class PluginInfo {
            internal const string ConfigFileName = "manifest.json";

            /// <summary>
            /// The name of the plugin.
            /// </summary>
            [JsonPropertyName("id")]
            public required string Id { get; set; }

            /// <summary>
            /// The name of the .NET assembly file that contains the plugin implementations.
            /// </summary>
            [JsonPropertyName("entryPoint")]
            public required string EntryPoint { get; set; }

            /// <summary>
            /// An additional folder with other dll dependencies to add to the library search path.
            /// </summary>
            [JsonPropertyName("libraryFolder")]
            public string? LibraryFolder { get; set; }

            public struct Dependency {
                /// <summary>
                /// The name of the dependency according to it's plugin name.
                /// </summary>
                [JsonPropertyName("id")]
                public required string Id { get; set; }
            }

            /// <summary>
            /// A list of dependencies that this plugin requires to function
            /// </summary>
            [JsonPropertyName("relationships")]
            public Dependency[] Dependencies { get; set; } = Array.Empty<Dependency>();

            public string? directory;
        }

        static readonly string PluginDirectory = Path.Combine(Environment.CurrentDirectory + "/plugins/");

        public static void InformPluginsLoadedCallbacks(Container dependencies) {
            foreach (IAfterPluginsLoaded callback in dependencies.ResolveMany<IAfterPluginsLoaded>()) {
                callback.AfterPluginsLoaded();
            }
        }

        public static bool LoadAllPlugins(Container dependencies) {
            string[] directories = Directory.GetDirectories(PluginDirectory);
            List<PluginInfo> plugins = new List<PluginInfo>();

            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions {
                ReadCommentHandling = JsonCommentHandling.Skip,
            };

            foreach (string directory in directories) {
                // Skip the Forge directory
                if (directory.StartsWith(Path.Combine(PluginDirectory, "Forge"), StringComparison.OrdinalIgnoreCase))
                    continue;


                // Check if config file exists
                string configFilePath = Path.Combine(directory, PluginInfo.ConfigFileName);
                if (!File.Exists(configFilePath)) {
                    Logger.LogError(null, $"Plugin at '{directory}' is missing a config file.");
                    continue;
                }

                // Load config file
                PluginInfo pluginInfo;
                try {
                    pluginInfo = JsonSerializer.Deserialize<PluginInfo>(File.ReadAllText(configFilePath), jsonSerializerOptions) ?? throw new SerializationException("Failed to deserialize plugin config file.");
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
                    if (plugin.directory == null) {
                        Logger.LogError(null, $"Plugin '{plugin.Id}' is missing a directory.");
                        continue;
                    }

                    string directory = plugin.directory;

                    bool missingDependencies = false;
                    string[] skippedDependencies = ["Forge", "UXEngine"];
                    var filteredDependencies = plugin.Dependencies.Where(d => !skippedDependencies.Contains(d.Id)).ToArray();
                    foreach (PluginInfo.Dependency dependency in filteredDependencies) {
                        PluginInfo? foundDependency = plugins.FirstOrDefault(p => p.Id == dependency.Id);
                        if (foundDependency != null) continue;

                        Logger.LogError(null, "Plugin '{0}' has a dependency '{1}' that does not exist.", plugin.Id, dependency.Id);
                        missingDependencies = true;
                        break;
                    }

                    if (missingDependencies) {
                        continue;
                    }


                    // Check if plugin assembly exists
                    string pluginPath = Path.Combine(directory, plugin.EntryPoint);
                    if (!File.Exists(pluginPath)) {
                        Logger.LogWarn("Plugin {0} is missing it's entry point assembly: '{1}'.", plugin.Id, pluginPath);
                        continue;
                    }

                    Logger.LogInfo("Loading Plugin '{0}'...", plugin.Id);

                    AssemblyInitializations.AddFolderLoadSource(directory);

                    if (plugin.LibraryFolder != null)
                        AssemblyInitializations.AddFolderLoadSource(Path.Combine(directory, plugin.LibraryFolder));

                    LoadPlugin(dependencies, pluginPath, directory);
                } catch (Exception e) {
                    while (e.InnerException != null) {
                        e = e.InnerException;
                    }

                    Logger.LogError(e, $"Error during load of plugin '{plugin.Id}'");
                }
            }

            InitializeAllPlugins(dependencies);

            return true;
        }

        private static bool CompareVersionsWithWildcard(string requiredVersion, string foundVersion) {
            if (!requiredVersion.Contains('*')) {
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

        private static void LoadPlugin(Container dependencies, string file, string directory) {
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

                // Register the plugins environment too:
                try {
                    Type pluginEnvironmentType = typeof(PluginEnvironment<>).MakeGenericType(pluginType);

                    // Normalize path and enforce trailing slash
                    string pluginPath = Path.GetFullPath(directory, Environment.CurrentDirectory).TrimEnd('\\', '/') + "\\";

                    // The environment has to instantiated here, just so it's easier to fill in any required parameters
                    object pluginEnvironment = Activator.CreateInstance(pluginEnvironmentType, BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] { pluginPath }, CultureInfo.InvariantCulture)!;
                    dependencies.RegisterInstance(pluginEnvironmentType, pluginEnvironment, IfAlreadyRegistered.Throw);
                } catch (Exception e) {
                    Logger.LogError(e, $"Failed to register Plugin Environment for '{pluginType.Name}'");
                    throw; // This is an indication that something much bigger is wrong, so just add a log and continue the throw
                }
            }
        }

        private static void InitializeAllPlugins(Container dependencies) {
            List<IPlugin> plugins = dependencies.ResolveMany<IPlugin>().ToList();
            plugins.Sort((x, y) => x.Priority - y.Priority);

            foreach (IPlugin plugin in plugins) {
                try {
                    Logger.LogInfo($"Registering Plugin dependencies for: '{plugin.GetType().Name}'...");
                    plugin.RegisterDependencies(dependencies);
                } catch (Exception e) {
                    string stackTrace = e.StackTrace ?? "N/A";
                    while (e.InnerException != null) {
                        e = e.InnerException;
                    }

                    string errorMsg =
                        $"Error during registration of Plugin dependencies for '{plugin.GetType().Name}'\nError: {e.Message}\n\n============= Stack Trace =============\n{stackTrace}";
                    Logger.LogError(e, errorMsg);
                }

            }

            foreach (IPlugin plugin in plugins) {
                try {
                    Logger.LogInfo($"Initializing Plugin '{plugin.GetType().Name}' with a priority of {plugin.Priority}...");
                    plugin.Initialize();
                } catch (Exception e) {
                    string stackTrace = e.StackTrace ?? "N/A";
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
