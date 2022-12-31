using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S4_UIEngine.UI.Components;
using S4_UIEngine.UI.Elements;
using S4_UIEngine.UI.Elements.Grouping;

namespace S4_UIEngine.UI {
    public static class SceneManager {
        private static List<UIElement> elements;

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
    }
}
