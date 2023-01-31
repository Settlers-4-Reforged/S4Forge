using S4UIEngine.Rendering.Text;
using S4UIEngine.Rendering.Texture;
using S4UIEngine.UI.Components;
using S4UIEngine.UI.Elements;
using System.Numerics;

namespace S4UIEngine.Rendering {
    public interface IRenderer {
        void RenderUIComponent(IUIComponent component, UIElement parent);
        void RenderTeamTexture(ITexture texture, Vector2 position, Vector2 size);

        ITextRenderer GetTextRenderer();

        Vector2 GetScreenSize();
    }
}
