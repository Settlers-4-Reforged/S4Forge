using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using S4_UIEngine.Rendering.Texture;

namespace S4_UIEngine.UI.Components {
    public class NineSliceTextureComponent : TextureComponent {
        //Slices:
        private float top, bottom, left, right;

        public NineSliceTextureComponent(ITexture texture, float top, float bottom, float left, float right) : base(texture) {
            this.top = top;
            this.bottom = bottom;
            this.left = left;
            this.right = right;
        }
    }
}
