using DryIoc;

using Forge.Config;
using Forge.Engine;
using Forge.Logging;
using Forge.Native;
using Forge.S4.Callbacks;
using Forge.S4.Managers;

using NetModAPI;

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Logger = Forge.Logging.Logger;
using NetLogger = NetModAPI.Logger;

namespace Forge {
    public class S4Forge : IForge {

        public void Initialize() {
            AssemblyInitializations.InitAssemblyLoadHandler();

            AddExceptionHandling();

            DI.Dependencies.RegisterInstanceMany(this);
            DI.Dependencies.Register<Callbacks>(Reuse.Singleton);
            ApiManager.RegisterDependencies();

            ModuleLoader.RegisterAvailableEngines(DI.Dependencies);

            var engines = DI.Dependencies.ResolveMany<IEngine>();

            foreach (IEngine engine in engines) {
                Logger.LogInfo($"Initializing \"{engine.Name}\"...");
                engine.Initialize();
                Logger.LogInfo($"Finished initializing \"{engine.Name}\"...");
            }

            if (!PluginLoader.LoadAllPlugins(DI.Dependencies)) {
                Logger.LogError(null, "There was an error during the loading of a (or all) plugins");
            } else {
                Logger.LogInfo("Finished loading all plugins");
            }

            Logger.LogInfo("Finished initializing Forge");
        }

        private void AddExceptionHandling() {
            TaskScheduler.UnobservedTaskException += (s, e) => {
                Logger.LogError(e.Exception, "An unobserved task exception was thrown");
            };
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionHandler;
            AppDomain.CurrentDomain.FirstChanceException += (s, e) => {
                Logger.LogError(e.Exception, "A first chance exception was thrown");
            };
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
