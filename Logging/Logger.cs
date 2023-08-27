using Forge.Engine;

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;

using NetLogger = NetModAPI.Logger;

namespace Forge.Logging {
    public static class Logger {
        public static bool Enabled = true;

        private static string GetEngineSource(Assembly caller) {
            var engine = ModuleLoader.GetIEngine(caller);
            if (engine == null)
                return "Generic";


            return engine.Name;
        }

        public static void LogInfo(string message, params object[] args) {
            if (!Enabled)
                return;

            string source = GetEngineSource(Assembly.GetCallingAssembly());
            NetLogger.LogInfo($"[{source}] " + string.Format(message, args));
        }
        public static void LogWarn(string message, params object[] args) {
            if (!Enabled)
                return;

            string source = GetEngineSource(Assembly.GetCallingAssembly());
            NetLogger.LogWarn($"[{source}] " + string.Format(message, args));
        }

        public static void LogDebug(string message, params object[] args) {
            if (!Enabled)
                return;

            string source = GetEngineSource(Assembly.GetCallingAssembly());
            NetLogger.LogDebug($"[{source}] " + string.Format(message, args));
        }

        public static void LogError(Exception? err, string? message, params object[] args) {
            if (!Enabled)
                return;

            string source = GetEngineSource(Assembly.GetCallingAssembly());
            NetLogger.LogError($"[{source}] " + string.Format(message, args), err);
        }

    }
}

