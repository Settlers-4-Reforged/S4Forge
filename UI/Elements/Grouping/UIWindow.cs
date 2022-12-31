using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S4_UIEngine.Rendering.Texture;
using S4_UIEngine.UI.Components;
using S4_UIEngine.UI.Elements.Static;

namespace S4_UIEngine.UI.Elements.Grouping {
    internal class UIWindow : UIGroup {
        
        public override bool PositionAbsolute => true;

        public UIWindow(NineSliceTextureComponent backgroundTexture) {
            Components = new List<IUIComponent>() { backgroundTexture };
        }
    }
}
