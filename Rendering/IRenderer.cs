using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using S4_UIEngine.Rendering.Text;
using S4_UIEngine.Rendering.Texture;
using S4_UIEngine.UI.Components;
using S4_UIEngine.UI.Elements;

namespace S4_UIEngine.Rendering {
    public interface IRenderer {
        void RenderUIComponent(IUIComponent component, UIElement parent);
        void RenderTeamTexture(ITexture texture, Vector2 position, Vector2 size);

        ITextRenderer GetTextRenderer();
    }
}
