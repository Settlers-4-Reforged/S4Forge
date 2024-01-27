using Forge.Engine;

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;

using NetLogger = NetModAPI.Logger;

namespace Forge.Logging {
    public abstract class Logger {
        public static bool Enabled = true;

        public class PrivateLogger : Logger {
            private readonly string name;
            public PrivateLogger(string name) {
                NetLogger.AddLogger(name);
                this.name = name;
            }

            public new void LogDebug(string message, params object[] args) {
                NetLogger.LogDebug(string.Format(message, args), name);
            }

            public new void LogError(Exception? err, string message, params object[] args) {
                NetLogger.LogError(string.Format(message, args), err, name);
            }

            public new void LogInfo(string message, params object[] args) {
                NetLogger.LogInfo(string.Format(message, args), name);
            }

            public new void LogWarn(string message, params object[] args) {
                NetLogger.LogWarn(string.Format(message, args), name);
            }
        }

        private static string GetEngineSource(Assembly caller) {
            Type? engine = ModuleLoader.GetIEngine(caller);
            return engine == null ? "Generic" : engine.Name;
        }

        public static PrivateLogger CreateLogger(string name) {
            return new PrivateLogger(name);
        }

        public static void LogInfo(string message, params object[] args) {
            if (!Enabled)
                return;

            string source = GetEngineSource(Assembly.GetCallingAssembly());
            NetLogger.LogInfo($"[{source}]>>" + string.Format(message, args));
        }
        public static void LogWarn(string message, params object[] args) {
            if (!Enabled)
                return;

            string source = GetEngineSource(Assembly.GetCallingAssembly());
            NetLogger.LogWarn($"[{source}]>>" + string.Format(message, args));
        }

        public static void LogDebug(string message, params object[] args) {
            if (!Enabled)
                return;

            string source = GetEngineSource(Assembly.GetCallingAssembly());
            NetLogger.LogDebug($"[{source}]>>" + string.Format(message, args));
        }

        public static void LogError(Exception? err, string message, params object[] args) {
            if (!Enabled)
                return;

            string source = GetEngineSource(Assembly.GetCallingAssembly());
            NetLogger.LogError($"[{source}]>>" + string.Format(message, args), err);
        }
    }
}

