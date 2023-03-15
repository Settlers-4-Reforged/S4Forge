using S4UI.UI;
using S4UI.UI.Components;
using S4UI.UI.Elements;
using System.Numerics;

namespace S4UI.Rendering {
    public interface IRenderer {
        void RenderUIComponent(IUIComponent component, UIElement parent, SceneGraphState sceneGraphState);


        Vector2 GetScreenSize();
    }
}
