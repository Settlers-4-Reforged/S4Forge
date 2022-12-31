using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace S4_UIEngine.UI.Components {
    public class TextComponent : IUIComponent {
        public Vector2 Offset { get; set; }
        public string Text { get; set; }

        public TextComponent(string text) {
            Text = text;
        }
    }
}
