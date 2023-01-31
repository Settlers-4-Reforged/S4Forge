using S4_UIEngine.UI.Components;
using System.Collections.Generic;

namespace S4_UIEngine.UI.Elements.Static {
    internal class UIText : UIElement {
        public UIText(string text) {
            Components = new List<IUIComponent>() { new TextComponent(text) };
        }
    }
}
