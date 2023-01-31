using S4_UIEngine.GameTypes;
using S4_UIEngine.UI.Components;
using S4_UIEngine.UI.Elements;
using S4_UIEngine.UI.Elements.Grouping;
using S4_UIEngine.UI.Elements.Grouping.Display;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace S4_UIEngine.UI {
    public static class SceneManager {
        private static RootNode rootSceneNode = new RootNode();


        static void Init() {
            UIEngine.GS.OnS4ScreenChange += OnScreenChange;
        }

        private static void OnScreenChange(GuiScreen prev, GuiScreen next) {
            foreach (UIWindow window in rootSceneNode.GetAllSceneElements().OfType<UIWindow>()) {
                if (!window.PersistMenus)
                    window.Close();
            }
        }

        static void DoFrame() { }

        static void RenderComponents(UIElement parent) {
            foreach (IUIComponent component in parent.Components) {
                UIEngine.R.RenderUIComponent(component, parent);
            }
        }

        static void RenderGroup(UIGroup group) {
            RenderComponents(group);

            foreach (UIElement el in group.Elements) {
                if (el is UIGroup g) {
                    RenderGroup(g);
                } else {
                    RenderComponents(el);
                }
            }
        }

        struct SceneGraphState {
            public Vector2 CurrentPosition;
            public Vector2 CurrentScale;

            public SceneGraphState(Vector2 currentPosition, Vector2 currentScale) {
                CurrentPosition = currentPosition;
                CurrentScale = currentScale;
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
}
