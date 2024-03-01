using CrashHandling;

using DryIoc;

using Forge.Config;
using Forge.Engine;
using Forge.Logging;
using Forge.Native;
using Forge.Notifications;
using Forge.S4.Callbacks;
using Forge.S4.Managers;

using NetModAPI;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Logger = Forge.Logging.Logger;
using NetLogger = NetModAPI.Logger;

namespace Forge {
    public class S4Forge : IForge {

        public void Initialize() {
            Logger.LogInfo("Initializing Forge...");

            AssemblyInitializations.InitAssemblyLoadHandler();

            AddExceptionHandling();

            DI.RegisterDefaultDependencies(this);

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
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionHandler;
            Logger.LogInfo("Added exception handling");
        }


        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [HandleProcessCorruptedStateExceptions]
        private void UnhandledExceptionHandler(object s, UnhandledExceptionEventArgs e) {
            Exception exception = (Exception)e.ExceptionObject;

#if DEBUG
            User32.MessageBox("Forge detected an unhandled managed exception and is now halting execution.\nEither attach a debugger, or ignore this error", "S4Forge");
#endif
            Logger.LogError(exception, "Forge detected an unhandled exception");

            StackTrace trace = new StackTrace(exception);

            ICrashReporter crashReporter = CrashReporterService.GetCrashReporter();
            crashReporter.AddPropertyToCrashReport("ManagedTrace", exception.StackTrace);


            Assembly[] pluginAssemblies = PluginLoader.GetActivePluginAssemblies().ToArray();
            Assembly? exceptionAssembly = null;

            for (int i = 0; i < trace.FrameCount; i++) {
                StackFrame frame = trace.GetFrame(i)!;
                MethodBase? method = frame.GetMethod();
                Assembly? declaringTypeAssembly = method?.DeclaringType?.Assembly;
                if (declaringTypeAssembly == null)
                    continue;

                if (pluginAssemblies.Contains(declaringTypeAssembly)) {
                    exceptionAssembly = declaringTypeAssembly;
                    break;
                }
            }

            if (exceptionAssembly == null) return;

            CrashReportSource source = new CrashReportSource();

            string exceptionMessage = "";
            // TODO: Add custom exception handling for plugins
            // Probably in form of a custom class in the plugin assembly that implements ICrashReporter

            // TODO: Improve stack trace handling with native stack

            crashReporter.ReportCrash(source, exceptionMessage);
            return;
        }

    }
}
