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

        private static readonly string[] Engines = new string[] { "UX-Engine.dll", "NetEngine.dll" };
        private const string EnginePath = @"\plugins\Forge\Engines\";
        private static string AbsoluteEnginePath => Environment.CurrentDirectory + EnginePath;

        internal static void RegisterAvailableEngines(Container dependencies) {
            Logger.LogInfo("Searching for available engines...");
            Logger.LogDebug($"Searching for the following engines: {string.Join(", ", Engines)}");

            foreach (string engine in Engines) {
                if (!System.IO.File.Exists(AbsoluteEnginePath + engine)) {
                    Logger.LogWarn($"Engine \"{engine}\" not found at \"{AbsoluteEnginePath}\"");
                    continue;
                }

                try {
                    Assembly engineAssembly = Assembly.LoadFile(AbsoluteEnginePath + engine);

                    AssemblyInitializations.AddAssemblyLoadSource(engineAssembly);

                    Type? iEngine = GetIEngine(engineAssembly);
                    if (iEngine == null) {
                        throw new EntryPointNotFoundException($"Failed to find IEngine in engine \"{engine}\"");
                    }

                    dependencies.RegisterMany(new[] { iEngine }, Reuse.Singleton);

                    Logger.LogInfo($"Registered engine \"{engine}\" at \"{AbsoluteEnginePath}\"");
                } catch (Exception ex) {
                    Logger.LogError($"Failed to load engine \"{engine}\" at \"{AbsoluteEnginePath}\"", ex);
                }
            }

        }
    }
}
