using Forge.Logging;
using Forge.Native;

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Forge.Config {
    public static class AssemblyInitializations {
        private static List<Assembly> assemblies = new List<Assembly>();
        private static List<string> folders = new List<string>();

        internal static void AddLegacyShims() {
            //Access to LegacyV2RuntimeEnabledSuccessfully triggers the static constructor of RuntimePolicyHelper - thus enabling the legacy runtime.
            Logger.LogDebug($"LegacyV2RuntimeEnabled: {RuntimePolicyHelper.LegacyV2RuntimeEnabledSuccessfully}");
        }

        public static void AddAssemblyLoadSource(Assembly assembly) {
            assemblies.Add(assembly);
        }

        public static void AddFolderLoadSource(string path) {
#pragma warning disable CS0618 // Type or member is obsolete
            AppDomain.CurrentDomain.AppendPrivatePath(path);
#pragma warning restore CS0618 // Type or member is obsolete
        }

        internal static void InitAssemblyLoadHandler() {
            folders.AddRange(new[] { @"plugins/", "plugins/Forge/Lib", "plugins/Forge/Engines", "plugins/Forge/Plugins" });

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

                List<string> searchedFolders = new List<string>();
                foreach (string folder in folders) {
                    string path = Path.Combine(Environment.CurrentDirectory, folder, assemblyName + ".dll");

                    searchedFolders.Add(path);
                    if (!File.Exists(path))
                        continue;

                    Logger.LogInfo($"Loading {assemblyName} from {path}...");

                    return Assembly.LoadFrom(path);
                }

                Logger.LogError(null, $"Failed to find assembly {assemblyName} in any of the following folders:\n{string.Join("\n", searchedFolders)}");

                return null;
            };
        }

    }
}
