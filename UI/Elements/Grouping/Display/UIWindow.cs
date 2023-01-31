using S4UIEngine.UI.Components;
using System.Collections.Generic;

namespace S4UIEngine.UI.Elements.Grouping.Display {
    internal class UIWindow : UIDisplay<UIWindow> {

        public override bool PositionAbsolute => true;

        /// <summary>
        /// Whether the window should stay open when the S4 menu changes
        /// </summary>
        public bool PersistMenus { get; set; } = true;

        public UIWindow() {
            Components = new List<IUIComponent>() { new NineSliceTextureComponent(null!, 0, 0, 0, 0) };
        }

        public UIWindow(NineSliceTextureComponent backgroundTexture) {
            Components = new List<IUIComponent>() { backgroundTexture };
        }

        protected override void CreateElement() {
            throw new System.NotImplementedException();
        }

        public void Open() {
            throw new System.NotImplementedException();
        }

        public void Close() {
            throw new System.NotImplementedException();
        }
    }
}
