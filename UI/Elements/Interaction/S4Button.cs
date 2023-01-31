using S4UIEngine.Rendering.Texture;
using S4UIEngine.UI.Components;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace S4UIEngine.UI.Elements.Interaction {
    public class S4Button : UIElement {
        public static ITexture? DefaultButtonTexture, DefaultButtonHeldTexture;
        public ITexture? ButtonTexture, ButtonHeldTexture;

        public Action<S4Button /*this*/> OnPress { get; set; }

        public string Text { get; set; }

        private TextureComponent textureComponentComponent;

        enum State {
            Up,
            Down,
        }

        private State state = State.Up;

        public void DefaultTextures() {
            ButtonTexture ??= DefaultButtonTexture ??= TextureCollectionManager.Get(0, 0);
            ButtonHeldTexture ??= DefaultButtonHeldTexture ??= TextureCollectionManager.Get(0, 0);
        }

        public S4Button() {
            DefaultTextures();
            textureComponentComponent = new TextureComponent(DefaultButtonTexture);

            Components = new List<IUIComponent>() {
                new TextComponent(Text) { Offset = new Vector2(0, 0) },
                textureComponentComponent,
            };
        }

        internal override void OnMouseClickDown(int mb) {
            OnPress?.Invoke(this);
        }
    }
}
