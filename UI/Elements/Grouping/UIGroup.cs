using System.Collections.Generic;

namespace S4_UIEngine.UI.Elements.Grouping {
    public class UIGroup : UIElement {
        public List<UIElement> Elements { get; set; }

        public bool ClipContent = false;

        public UIGroup() {
            Elements ??= new List<UIElement>();
        }
    }
}
