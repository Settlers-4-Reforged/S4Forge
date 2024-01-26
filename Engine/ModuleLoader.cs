using DryIoc;

using Forge.Config;

using NetModAPI;

using System;
using System.Linq;
using System.Reflection;

namespace Forge.Engine {
    internal static class ModuleLoader {
        public static Type? GetIEngine(Assembly assembly) {
            Type[] types = assembly.GetExportedTypes();

            Type? iEngine = (from Type t in types
                             where t.GetInterface(nameof(IEngine)) != null
                             select t).FirstOrDefault();

            return iEngine;
        }

        private static readonly string[] Engines = new string[] { "UX-Engine.dll" };
        private const string EnginePath = @"\plugins\Forge\Engines\";

        internal static void RegisterAvailableEngines(Container dependencies) {
            foreach (string engine in Engines) {
                try {
                    Assembly engineAssembly = Assembly.LoadFile(Environment.CurrentDirectory + EnginePath + engine);

                    AssemblyInitializations.AddAssemblyLoadSource(engineAssembly);

                    Type? iEngine = GetIEngine(engineAssembly);
                    if (iEngine == null) {
                        throw new EntryPointNotFoundException($"Failed to find IEngine in engine \"{engine}\"");
                    }

                    dependencies.RegisterMany(new[] { iEngine }, Reuse.Singleton);
                } catch (Exception ex) {
                    Logger.LogError($"Failed to load engine \"{engine}\" at \"{Environment.CurrentDirectory + EnginePath}\"", ex);
                }
            }

        }
    }
}
