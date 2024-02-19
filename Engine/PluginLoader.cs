using DryIoc;

using Forge.Config;
using Forge.Logging;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Forge.Engine {
    internal static class PluginLoader {
        const string PluginExtension = "*.nasi";

        static readonly string PluginDirectory = Path.Combine(Environment.CurrentDirectory + "/plugins/Forge/Plugins");
        const string PluginLibFolder = "Lib";

        public static bool LoadAllPlugins(Container dependencies) {
            var files = Directory.GetFiles(PluginDirectory, PluginExtension);

            Logger.LogInfo($"Found {files.Length} plugin(s) to load.");

            foreach (string file in files) {
                try {
                    string msg = $"Loading Plugin Assembly '{file}'...";
                    Logger.LogInfo(msg);

                    Assembly pluginAssembly = Assembly.LoadFrom(file);
                    AssemblyInitializations.AddAssemblyLoadSource(pluginAssembly);

                    string pluginFolder = Path.Combine(PluginDirectory, Path.GetFileNameWithoutExtension(file));
                    bool hasPluginFolder = Directory.Exists(pluginFolder);
                    if (hasPluginFolder) {
                        AssemblyInitializations.AddFolderLoadSource(Path.Combine(pluginFolder, PluginLibFolder));
                    }

                    var types = new List<Type>(pluginAssembly.GetTypes());

                    Type[] pluginTypes = (from Type t in types
                                          where
                                              t.GetInterface(nameof(IPlugin)) != null &&
                                              !t.IsAbstract &&
                                              !t.IsInterface
                                          select t).ToArray();

                    if (pluginTypes.Length == 0) {
                        Logger.LogError(null, $"Failed to find any valid plugin classes in '{file}'");
                        continue;
                    }

                    foreach (Type pluginType in pluginTypes) {
                        Logger.LogInfo($"Found Plugin '{pluginType.Name}'");
                        dependencies.RegisterMany(new[] { pluginType }, Reuse.Singleton);
                    }


                } catch (Exception e) {
                    string stackTrace = e.StackTrace;
                    while (e.InnerException != null) {
                        e = e.InnerException;
                    }

                    string errorMsg = $"Error during load of Assembly '{file}'";
                    Logger.LogError(e, errorMsg);
                }
            }

            InitializeAllPlugins(dependencies);

            return true;
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
    }
}
