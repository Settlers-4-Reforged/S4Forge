using Forge.Logging;
using Forge.Native;

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Forge.Config {
    internal static class AssemblyInitializations {
        private static List<Assembly> assemblies = new List<Assembly>();

        public static void AddLegacyShims() {
            //Access to LegacyV2RuntimeEnabledSuccessfully triggers the static constructor of RuntimePolicyHelper - thus enabling the legacy runtime.
            Logger.LogDebug($"LegacyV2RuntimeEnabled: {RuntimePolicyHelper.LegacyV2RuntimeEnabledSuccessfully}");
        }

        public static void AddAssemblyLoadSource(Assembly assembly) {
            assemblies.Add(assembly);
        }

        public static void InitAssemblyLoadHandler() {
            assemblies = new List<Assembly> { Assembly.GetExecutingAssembly() };

            AppDomain.CurrentDomain.AssemblyResolve += static (sender, args) => {
                // Guessing embedded dll name:
                string assemblyName = new AssemblyName(args.Name).Name;
                string resourceName = assemblyName + ".dll";

                foreach (Assembly assembly in assemblies) {
                    Logger.LogDebug($"Checking assembly {assembly.GetName().Name} for {resourceName}");
                    string resource = Array.Find(assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));
                    if (resource == null)
                        continue;

                    Logger.LogInfo($"Loading {assemblyName} from Embedded Resources of source assembly {assembly.GetName().Name}...");

                    using Stream stream = assembly.GetManifestResourceStream(resource)!;

                    byte[] assemblyData = new byte[stream.Length];
                    int read = stream.Read(assemblyData, 0, assemblyData.Length);
                    if (read != assemblyData.Length) {
                        Logger.LogError(null, $"Failed to read all bytes from embedded resource {resource} of assembly {assembly.GetName().Name}");
                        return null;
                    }
                    return Assembly.Load(assemblyData);
                }

                return null;
            };
        }

    }
}
