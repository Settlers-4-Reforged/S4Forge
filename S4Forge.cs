using Forge.Config;
using Forge.Engine;
using Forge.Native;

using NetModAPI;

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Text;

using Logger = Forge.Logging.Logger;
using NetLogger = NetModAPI.Logger;

namespace Forge {
    public class S4Forge : IForge {
        public void Initialize() {
            AssemblyInitializations.InitAssemblyLoadHandler();
            AssemblyInitializations.AddLegacyShims();

            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionHandler;

            IEnumerable<IEngine> engines = ModuleLoader.CreateAvailableEngines();

            foreach (IEngine engine in engines) {
                Logger.LogInfo($"Initializing \"{engine.Name}\"...");
                engine.Initialize(this);
                Logger.LogInfo($"Finished initializing \"{engine.Name}\"...");
            }

            if (!PluginLoader.LoadAllPlugins()) {
                Logger.LogError(null, "There was an error during the loading of a (or all) plugins");
            } else {
                Logger.LogInfo("Finished loading all plugins");
            }

            Logger.LogInfo("Finished initializing Forge");
        }


        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [HandleProcessCorruptedStateExceptions()]
        private void UnhandledExceptionHandler(object s, UnhandledExceptionEventArgs e) {
            Logger.LogError((Exception)e.ExceptionObject, "Forge detected an unhandled exception");
#if DEBUG
            User32.MessageBox("Forge detected an unhandled exception and is now halting execution.\nEither attach a debugger, or ignore this error", "S4Forge");
#endif
        }

    }
}
