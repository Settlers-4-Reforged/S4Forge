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
    internal static class ModuleLoader {
        /// <summary>
        /// An extension to the ForgeUpdater manifest. Manifest struct is not imported to avoid dependency
        /// </summary>
        class ModuleInfo {
            internal const string ConfigFileName = "manifest.json";

            /// <summary>
            /// The name of the module.
            /// </summary>
            [JsonPropertyName("id")]
            public required string Id { get; set; }

            /// <summary>
            /// The name of the .NET assembly file that contains the module implementations.
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
                /// The name of the dependency according to it's module name.
                /// </summary>
                [JsonPropertyName("id")]
                public required string Id { get; set; }
            }

            /// <summary>
            /// A list of dependencies that this module requires to function
            /// </summary>
            [JsonPropertyName("relationships")]
            public Dependency[] Dependencies { get; set; } = Array.Empty<Dependency>();

            public string? directory;
        }

        static readonly string ModuleDirectory = Path.Combine(Environment.CurrentDirectory + "/plugins/Modules/");

        public static void InformModulesLoadedCallbacks(Container dependencies) {
            foreach (IAfterModulesLoaded callback in dependencies.ResolveMany<IAfterModulesLoaded>()) {
                callback.AfterModulesLoaded();
            }
        }

        public static bool LoadAllModules(Container dependencies) {
            string[] directories = Directory.GetDirectories(ModuleDirectory);
            List<ModuleInfo> modules = new List<ModuleInfo>();

            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions {
                ReadCommentHandling = JsonCommentHandling.Skip,
            };

            foreach (string directory in directories) {
                // Check if config file exists
                string configFilePath = Path.Combine(directory, ModuleInfo.ConfigFileName);
                if (!File.Exists(configFilePath)) {
                    Logger.LogInfo("Module at '{0}' is missing a config file.", directory);
                    continue;
                }

                // Load config file
                ModuleInfo moduleInfo;
                try {
                    moduleInfo = JsonSerializer.Deserialize<ModuleInfo>(File.ReadAllText(configFilePath), jsonSerializerOptions) ?? throw new SerializationException("Failed to deserialize module config file.");
                } catch (Exception e) {
                    Logger.LogError(e, $"Error during load of config file '{configFilePath}'");
                    continue;
                }

                moduleInfo.directory = directory;
                modules.Add(moduleInfo);
            }

            Logger.LogInfo($"Found {modules.Count} module(s) to load.");

            foreach (ModuleInfo module in modules) {
                try {
                    if (module.directory == null) {
                        Logger.LogError(null, $"Module '{module.Id}' is missing a directory.");
                        continue;
                    }

                    string directory = module.directory;

                    bool missingDependencies = false;
                    string[] skippedDependencies = ["Forge", "UXEngine"];
                    var filteredDependencies = module.Dependencies.Where(d => !skippedDependencies.Contains(d.Id)).ToArray();
                    foreach (ModuleInfo.Dependency dependency in filteredDependencies) {
                        ModuleInfo? foundDependency = modules.FirstOrDefault(p => p.Id == dependency.Id);
                        if (foundDependency != null) continue;

                        Logger.LogError(null, "Module '{0}' has a dependency '{1}' that does not exist.", module.Id, dependency.Id);
                        missingDependencies = true;
                        break;
                    }

                    if (missingDependencies) {
                        continue;
                    }


                    // Check if module assembly exists
                    string modulePath = Path.Combine(directory, module.EntryPoint);
                    if (!File.Exists(modulePath)) {
                        Logger.LogWarn("Module {0} is missing it's entry point assembly: '{1}'.", module.Id, modulePath);
                        continue;
                    }

                    Logger.LogInfo("Loading module '{0}'...", module.Id);

                    AssemblyInitializations.AddFolderLoadSource(directory);

                    if (module.LibraryFolder != null)
                        AssemblyInitializations.AddFolderLoadSource(Path.Combine(directory, module.LibraryFolder));

                    LoadModule(dependencies, modulePath, directory);
                } catch (Exception e) {
                    while (e.InnerException != null) {
                        e = e.InnerException;
                    }

                    Logger.LogError(e, $"Error during load of module '{module.Id}'");
                }
            }

            InitializeAllModules(dependencies);

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

        private static void LoadModule(Container dependencies, string file, string directory) {
            string msg = $"Loading module assembly '{file}'...";
            Logger.LogInfo(msg);

            Assembly moduleAssembly = Assembly.LoadFrom(file);
            AssemblyInitializations.AddAssemblyLoadSource(moduleAssembly);

            var types = new List<Type>(moduleAssembly.GetTypes());

            Type[] moduleTypes = [..from Type t in types where
                                      t.GetInterface(nameof(IModule)) != null &&
                                      !t.IsAbstract &&
                                      !t.IsInterface
                                  select t];

            if (moduleTypes.Length == 0) {
                Logger.LogError(null, "Failed to find any valid module classes in '$0'", file);
                return;
            }

            if (moduleTypes.Length > 1) {
                Logger.LogWarn("Found more than 1 ($0) module implementation in $1", moduleTypes.Length, file);
            }

            foreach (Type moduleType in moduleTypes) {
                Logger.LogInfo($"Found Module '{moduleType.Name}'");
                dependencies.RegisterMany(new[] { moduleType }, Reuse.Singleton);

                // Register the module's environment too:
                try {
                    Type moduleEnvironmentType = typeof(ModuleEnvironment<>).MakeGenericType(moduleType);

                    // Normalize path and enforce trailing slash
                    string modulePath = Path.GetFullPath(directory, Environment.CurrentDirectory).TrimEnd('\\', '/') + "\\";

                    // The environment has to instantiated here, just so it's easier to fill in any required parameters
                    object moduleEnvironment = Activator.CreateInstance(moduleEnvironmentType, BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] { modulePath }, CultureInfo.InvariantCulture)!;
                    dependencies.RegisterInstance(moduleEnvironmentType, moduleEnvironment, IfAlreadyRegistered.Throw);
                } catch (Exception e) {
                    Logger.LogError(e, $"Failed to register module environment for '{moduleType.Name}'");
                    throw; // This is an indication that something much bigger is wrong, so just add a log and continue the throw
                }
            }
        }

        private static void InitializeAllModules(Container dependencies) {
            List<IModule> modules = dependencies.ResolveMany<IModule>().ToList();
            modules.Sort((x, y) => x.Priority - y.Priority);

            foreach (IModule module in modules) {
                try {
                    Logger.LogInfo($"Initializing module '{module.GetType().Name}' with a priority of {module.Priority}...");
                    module.Initialize(dependencies);
                } catch (Exception e) {
                    string stackTrace = e.StackTrace ?? "N/A";
                    while (e.InnerException != null) {
                        e = e.InnerException;
                    }

                    string errorMsg =
                        $"Error during initialization of module '{module.GetType().Name}'\nError: {e.Message}\n\n============= Stack Trace =============\n{stackTrace}";
                    Logger.LogError(e, errorMsg);
                }
            }
        }

        public static IEnumerable<Assembly> GetActiveModuleAssemblies() {
            return DI.Dependencies.ResolveMany<IModule>().Select(module => module.GetType().Assembly).DistinctBy(assembly => assembly.Location);
        }
    }
}
