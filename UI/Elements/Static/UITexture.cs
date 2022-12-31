using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S4_UIEngine.UI.Components;

namespace S4_UIEngine.UI.Elements.Static {
    internal class UITexture : UIElement {
        public UITexture(TextureComponent texture) {
            Components = new List<IUIComponent>() { texture };
        }
    }
}
