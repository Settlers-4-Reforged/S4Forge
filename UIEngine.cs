using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S4_UIEngine.Settings;

namespace S4_UIEngine {
    public static class UIEngine {
        private static readonly IInputManager inputManager;
        private static readonly IGameSettings gameSettings;

        internal static IInputManager IM => inputManager;

        internal static IGameSettings GS => gameSettings;


        static void Initialize() { }
    }
}
