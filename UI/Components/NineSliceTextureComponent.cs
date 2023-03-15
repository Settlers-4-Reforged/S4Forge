using S4UI.Rendering.Texture;

namespace S4UI.UI.Components {
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
