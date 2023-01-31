using S4UIEngine.Rendering;
using S4UIEngine.S4.Managers;
using System;

namespace S4UIEngine {
    public static class UIEngine {
        private static IInputManager? inputManager;
        private static IGameSettings? gameSettings;
        private static IRenderer? renderer;
        private static IGameManager? gameManager;

        internal static IInputManager IM => inputManager ?? throw new InvalidOperationException();

        internal static IGameSettings GS => gameSettings ?? throw new InvalidOperationException();

        internal static IRenderer R => renderer ?? throw new InvalidOperationException();

        internal static IGameManager GM => gameManager ?? throw new InvalidOperationException();

        public static void Initialize(IInputManager input, IGameSettings settings, IRenderer rendererEngine, IGameManager gameManager) {
            UIEngine.inputManager = input;
            UIEngine.gameSettings = settings;
            UIEngine.renderer = rendererEngine;
            UIEngine.gameManager = gameManager;
        }
    }
}
