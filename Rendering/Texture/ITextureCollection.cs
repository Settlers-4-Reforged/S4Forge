using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4UI.Rendering.Texture
{
    public interface ITextureCollection
    {
        ITexture GetTexture(int id);
    }
}
