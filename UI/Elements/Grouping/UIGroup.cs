using System.Collections.Generic;

namespace S4UIEngine.UI.Elements.Grouping {
    public class UIGroup : UIElement {
        public List<UIElement> Elements { get; set; }

        public bool ClipContent { get; set; } = false;

        public UIGroup() {
            Elements ??= new List<UIElement>();
        }
    }
}
