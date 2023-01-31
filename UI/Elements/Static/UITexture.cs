using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S4UIEngine.UI.Components;

namespace S4UIEngine.UI.Elements.Static {
    internal class UITexture : UIElement {
        public UITexture(TextureComponent texture) {
            Components = new List<IUIComponent>() { texture };
        }
    }
}
