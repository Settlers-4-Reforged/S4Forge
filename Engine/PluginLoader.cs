using Forge.Logging;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Forge.Engine {
    internal static class PluginLoader {
        const string PluginExtension = "*.nasi";

        public static bool LoadAllPlugins() {
            var files = Directory.GetFiles(Environment.CurrentDirectory + "/plugins/", PluginExtension);

            Logger.LogInfo($"Found {files.Length} plugin(s) to load.");

            List<IPlugin> plugins = new List<IPlugin>();

            foreach (string file in files) {
                try {
                    string msg = $"Loading Plugin Assembly '{file}'...";
                    Logger.LogInfo(msg);

                    Assembly pluginAssembly = Assembly.LoadFrom(file);

                    var types = new List<Type>(pluginAssembly.GetTypes());

                    Type? pluginClass = (from Type t in types
                                         where
                                             t.GetInterface(nameof(IPlugin)) != null &&
                                             !t.IsAbstract &&
                                             !t.IsInterface
                                         select t).FirstOrDefault();
                    if (pluginClass == null) {
                        Logger.LogError(null, $"Failed to find a valid plugin class in '{file}'");
                        continue;
                    }
                    Logger.LogInfo($"Found Plugin '{pluginClass.Name}'");

                    IPlugin plugin = (IPlugin)(Activator.CreateInstance(pluginClass));
                    plugins.Add(plugin);
                } catch (Exception e) {
                    string stackTrace = e.StackTrace;
                    while (e.InnerException != null) {
                        e = e.InnerException;
                    }

                    string errorMsg =
                        $"Error during load of Assembly '{file}'\nError: {e.Message}\n\n============= Stack Trace =============\n{stackTrace}";
                    Logger.LogError(e, errorMsg);
                }
            }

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
                        $"Error during Initialization of Plugin '{plugin.GetType().Name}'\nError: {e.Message}\n\n============= Stack Trace =============\n{stackTrace}";
                    Logger.LogError(e, errorMsg);
                }
            }

            return true;
        }
    }
}
