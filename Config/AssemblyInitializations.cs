using Forge.Logging;
using Forge.Native;

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Forge.Config {
    public static partial class AssemblyInitializations {
        private static List<Assembly> assemblies = new List<Assembly>();
        private static readonly List<string> folders = new List<string>();

        [LibraryImport("kernel32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static partial bool AddDllDirectory(string path);

        [LibraryImport("kernel32", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static partial bool SetDefaultDllDirectories(int directoryFlags);

        public static void AddAssemblyLoadSource(Assembly assembly) {
            assemblies.Add(assembly);
        }

        public static void AddFolderLoadSource(string path) {
#pragma warning disable CS0618 // Type or member is obsolete
            AppDomain.CurrentDomain.AppendPrivatePath(path);
            AddDllDirectory(path);
#pragma warning restore CS0618 // Type or member is obsolete
        }

        internal static void InitAssemblyLoadHandler() {
            // ReSharper disable once InconsistentNaming
            const int LOAD_LIBRARY_SEARCH_USER_DIRS = 0x00000400;
            SetDefaultDllDirectories(LOAD_LIBRARY_SEARCH_USER_DIRS);

            folders.AddRange(new[] { @"plugins/", "plugins/Forge/Lib", "plugins/Forge/Engines", "plugins/Forge/Plugins" });
            foreach (string folder in folders) {
                AddFolderLoadSource(Path.Combine(Environment.CurrentDirectory, folder));
            }

            assemblies = new List<Assembly> { Assembly.GetExecutingAssembly() };

            AppDomain.CurrentDomain.AssemblyResolve += static (sender, args) => {
                // Guessing embedded dll name:
                string assemblyName = new AssemblyName(args.Name).Name!;
                string resourceName = assemblyName + ".dll";

                foreach (Assembly assembly in assemblies) {
                    Logger.LogDebug($"Checking assembly {assembly.GetName().Name} for {resourceName}");
                    string? resource = Array.Find(assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));
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
