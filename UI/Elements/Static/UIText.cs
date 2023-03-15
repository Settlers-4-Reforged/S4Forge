using System.Collections.Generic;
using S4UI.UI.Components;

namespace S4UI.UI.Elements.Static {
    internal class UIText : UIElement {
        public UIText(string text) {
            Components = new List<IUIComponent>() { new TextComponent(text) };
        }
    }
}
