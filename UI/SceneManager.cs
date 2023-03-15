using S4UI.S4.Types;
using S4UI.UI.Components;
using S4UI.UI.Elements;
using S4UI.UI.Elements.Grouping;
using S4UI.UI.Elements.Grouping.Display;

using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace S4UI.UI {
    public static class SceneManager {
        private static readonly RootNode rootSceneNode = new RootNode();


        static void Init() {
            UIEngine.GM.RegisterS4ScreenChangeCallback(OnScreenChange);
        }

        private static void OnScreenChange(UIScreen prev, UIScreen next) {
            foreach (UIWindow window in rootSceneNode.GetAllSceneElements().OfType<UIWindow>()) {
                if (!window.PersistMenus)
                    window.Close();
            }
        }

        static void DoFrame() {
            SceneGraphState baseState = SceneGraphState.Default();

            RenderGroup(rootSceneNode, baseState);
        }

        static void RenderComponents(UIElement parent, SceneGraphState state) {
            foreach (IUIComponent component in parent.Components) {
                UIEngine.R.RenderUIComponent(component, parent, state);
            }
        }

        static void RenderGroup(UIGroup group, SceneGraphState state) {
            SceneGraphState newState = state.ApplyGroup(group);

            RenderComponents(group, newState);

            foreach (UIElement el in group.GetSortedElements()) {
                if (el is UIGroup g) {
                    RenderGroup(g, newState);
                } else {
                    RenderComponents(el, newState);
                }
            }
        }

        class RootNode : UIGroup {
            public List<UIElement> GetAllSceneElements() {
                List<UIElement> elements = new List<UIElement>();

                static void GetChildElements(UIGroup parent, ref List<UIElement> elements) {
                    foreach (UIElement child in parent.Elements) {
                        if (child is UIGroup g) {
                            GetChildElements(g, ref elements);
                        }

                        elements.Add(child);
                    }
                }


                GetChildElements(this, ref elements);

                return elements;
            }
        }
    }

    public struct SceneGraphState {
        public Vector2 CurrentPosition { get; private set; }
        public Vector2 CurrentScale { get; private set; } //Unused ATM
        public Vector4 ClippingRect { get; private set; }

        public int Depth { get; private set; }

        public bool DebugActive { get; private set; }

        public SceneGraphState(Vector2 currentPosition, Vector2 currentScale, Vector4 clippingRect, int depth) {
            CurrentPosition = currentPosition;
            CurrentScale = currentScale;
            ClippingRect = clippingRect;
            Depth = depth;
            DebugActive = false;
        }
        public SceneGraphState Clone() {
            return new SceneGraphState(CurrentPosition, CurrentScale, ClippingRect, Depth) { DebugActive = this.DebugActive };
        }

        public SceneGraphState ApplyGroup(UIGroup group) {
            SceneGraphState next = this.Clone();

            next.Depth++;

            if (group.PositionAbsolute) {
                next.CurrentPosition = group.Position;
            } else {
                next.CurrentPosition += group.Position;
            }

            if (group.ClipContent) {
                next.ClippingRect = new Vector4(group.Position, group.Size.X, group.Size.Y);
            }

            return next;
        }

        public static SceneGraphState Default() {
            Vector2 screenSize = UIEngine.R.GetScreenSize();

            return new SceneGraphState(Vector2.Zero, Vector2.One, new Vector4(0, 0, screenSize.X, screenSize.Y), 0);
        }
    }
}
