using System.Numerics;

namespace S4UI.UI.Components {
    public class TextComponent : IUIComponent {
        public Vector2 Offset { get; set; }
        public string Text { get; set; }

        public TextComponent(string text) {
            Text = text;
        }
    }
}
