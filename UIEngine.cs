using S4_UIEngine.Rendering;
using S4_UIEngine.Settings;
using System;

namespace S4_UIEngine {
    public static class UIEngine {
        private static IInputManager? inputManager;
        private static IGameSettings? gameSettings;
        private static IRenderer? renderer;

        internal static IInputManager IM => inputManager ?? throw new InvalidOperationException();

        internal static IGameSettings GS => gameSettings ?? throw new InvalidOperationException();

        internal static IRenderer R => renderer ?? throw new InvalidOperationException();

        public static void Initialize(IInputManager input, IGameSettings settings, IRenderer rendererEngine) {
            UIEngine.inputManager = input;
            UIEngine.gameSettings = settings;
            UIEngine.renderer = rendererEngine;
        }
    }
}
