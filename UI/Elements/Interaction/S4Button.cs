using S4UI.Rendering.Texture;
using S4UI.UI.Components;

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Numerics;

namespace S4UI.UI.Elements.Interaction {
    public class S4Button : UIElement {
        public static ITexture? DefaultButtonTexture, DefaultButtonHeldTexture;
        public ITexture? ButtonTexture, ButtonHeldTexture;

        public Action<S4Button /*this*/>? OnPress { get; set; }

        public string Text { get; set; }

        private List<IUIComponent> components;
        public override List<IUIComponent> Components {
            get {
                TextureComponent? tex = (TextureComponent)components[1];

                switch (state) {
                    case State.Down:
                        tex.Texture = ButtonHeldTexture!;
                        break;
                    case State.Up:
                        tex.Texture = ButtonTexture!;
                        break;
                }

                return components;
            }
        }


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

            components = new List<IUIComponent>() {
                new TextComponent(Text ?? "NO TEXT") { Offset = new Vector2(0, 0) },
                new TextureComponent(DefaultButtonTexture!),
            };
        }

        internal override void OnMouseClickDown(int mb) {
            state = State.Down;
        }

        internal override void OnMouseClickUp(int mb) {
            OnPress?.Invoke(this);
            state = State.Up;
        }

        internal override void OnMouseLeave() {
            state = State.Up;
        }
    }
}
