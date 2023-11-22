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

        public static bool LoadAllPlugins(Container dependencies) {
            var files = Directory.GetFiles(Environment.CurrentDirectory + "/plugins/Forge/Plugins", PluginExtension);

            Logger.LogInfo($"Found {files.Length} plugin(s) to load.");

            foreach (string file in files) {
                try {
                    string msg = $"Loading Plugin Assembly '{file}'...";
                    Logger.LogInfo(msg);

                    Assembly pluginAssembly = Assembly.LoadFrom(file);

                    AssemblyInitializations.AddAssemblyLoadSource(pluginAssembly);

                    var types = new List<Type>(pluginAssembly.GetTypes());

                    Type? pluginType = (from Type t in types
                                        where
                                            t.GetInterface(nameof(IPlugin)) != null &&
                                            !t.IsAbstract &&
                                            !t.IsInterface
                                        select t).FirstOrDefault();
                    if (pluginType == null) {
                        Logger.LogError(null, $"Failed to find a valid plugin class in '{file}'");
                        continue;
                    }
                    Logger.LogInfo($"Found Plugin '{pluginType.Name}'");

                    dependencies.RegisterMany(new[] { pluginType }, Reuse.Singleton);
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
