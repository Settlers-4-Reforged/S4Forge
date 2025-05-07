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

            EngineLoader.LoadAllEngines(DI.Dependencies);

            ApiManager.ResolveDependencies();

            if (!ModuleLoader.LoadAllModules(DI.Dependencies)) {
                Logger.LogError(null, "There was an error during the loading of one (or all) modules");
            } else {
                Logger.LogInfo("Finished loading all modules");
            }

            ModuleLoader.InformModulesLoadedCallbacks(DI.Dependencies);

            Logger.LogDebug("Activating all registered plugins");
            var genericPlugins = DI.Dependencies.Resolve<IPlugin[]>();
            foreach (var plugin in genericPlugins) {
                plugin.Activate();
            }

            Logger.LogInfo("Finished initializing Forge");
        }

        private void AddExceptionHandling() {
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionHandler;
            AppDomain.CurrentDomain.FirstChanceException += AppendNativeStackToExceptionHandler;
            Logger.LogInfo("Added exception handling");
        }

        private void AppendNativeStackToExceptionHandler(object? sender, FirstChanceExceptionEventArgs e) {
            // NOTE(Jonas): This _could_ lead to a stack overflow as we maybe trip into an exception when rendering the stack trace
            // I don't quite know how to correctly detect that, so just hopes and prayers keep this code here together
            e.Exception.Data.Add("Stack", DebugService.GetFullStacktrace(6, true));
        }

        private void UnhandledExceptionHandler(object s, UnhandledExceptionEventArgs e) {
            Exception exception = (Exception)e.ExceptionObject;

            Logger.LogError(exception, "Forge detected an unhandled exception");

#if DEBUG
            User32.MessageBox($"Forge detected an unhandled managed exception and is now halting execution.\n{exception.Message}\nEither attach a debugger, or ignore this error", "S4Forge");
#endif

            DebugReportSource source = new DebugReportSource();

            string exceptionMessage = "";
            // TODO: Add custom exception handling for plugins
            // Probably in form of a custom class in the plugin assembly that implements ICrashReporter

            IDebugReporter crashReporter = DebugService.GetReporter();
            crashReporter.ReportException(source, exceptionMessage, exception, true);
        }

    }
}
