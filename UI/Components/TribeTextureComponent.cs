using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S4_UIEngine.GameTypes;
using S4_UIEngine.Rendering.Texture;

namespace S4_UIEngine.UI.Components {
    // Changes based on current tribe - defaults to DEFAULT if a tribe is not specified
    public class TribeTextureComponent : TextureComponent {
        public override ITexture Texture {
            get {
                Tribe c = UIEngine.GS.GetCurrentTribe();
                if (!textures.TryGetValue(c, out ITexture? o)) {
                    o = textures[Tribe.DEFAULT];
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
