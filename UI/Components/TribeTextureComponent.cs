using S4UIEngine.Rendering.Texture;
using S4UIEngine.S4.Types;
using System.Collections.Generic;

namespace S4UIEngine.UI.Components {
    // Changes based on current tribe - defaults to DEFAULT if a tribe is not specified
    public class TribeTextureComponent : TextureComponent {
        public override ITexture Texture {
            get {
                Tribe c = UIEngine.GS.GetCurrentTribe();
                if (!textures.TryGetValue(c, out ITexture? o)) {
                    o = textures[Tribe.Default];
                }

                return o;
            }
        }

        private readonly IDictionary<Tribe, ITexture> textures;

        public TribeTextureComponent(IDictionary<Tribe, ITexture> textures) : base() {
            this.textures = textures;
        }
    }
}
