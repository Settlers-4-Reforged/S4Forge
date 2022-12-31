using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_UIEngine.Rendering.Text {
    public enum TextType {
        Normal,
        Bold,
        Thin,
        Italic
    }

    public enum TextAlignment {
        Left,
        Center,
        Right
    }

    public enum TextSize {
        Small,
        Regular,
        Large
    }

    public struct TextStyle {
        private TextType type;
        private TextSize size;
        private TextAlignment alignment;
    }
}
