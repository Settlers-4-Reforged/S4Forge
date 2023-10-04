using Forge.Config;

using NetModAPI;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Forge.Engine {
    internal static class ModuleLoader {
        public static Type? GetIEngine(Assembly assembly) {
            Type[] types = assembly.GetExportedTypes();

            Type? iEngine = (from Type t in types
                             where t.GetInterface(nameof(IEngine)) != null
                             select t).FirstOrDefault();

            return iEngine;
        }

        private static readonly string[] Engines = new string[] { "UX-Engine.dll", "Plugin-Engine.dll" };
        private const string EnginePath = @"\plugins\Forge\Engines\";

        public static IEnumerable<IEngine> CreateAvailableEngines() {
            List<IEngine> engines = new List<IEngine>();

            foreach (string engine in Engines) {
                try {
                    Assembly engineAssembly = Assembly.LoadFile(Environment.CurrentDirectory + EnginePath + engine);

                    AssemblyInitializations.AddAssemblyLoadSource(engineAssembly);

                    Type? iEngine = GetIEngine(engineAssembly);
                    if (iEngine == null) {
                        throw new EntryPointNotFoundException($"Failed to find IEngine in engine \"{engine}\"");
                    }

                    IEngine engineObject = (IEngine)Activator.CreateInstance(iEngine);
                    engines.Add(engineObject);
                } catch (Exception ex) {
                    Logger.LogError($"Failed to load engine \"{engine}\" at \"{Environment.CurrentDirectory + EnginePath}\"", ex);
                }
            }

            return engines;
        }
    }
}
