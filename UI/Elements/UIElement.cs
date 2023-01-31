using S4_UIEngine.Rendering;
using S4_UIEngine.UI.Components;
using System.Collections.Generic;
using System.Numerics;

namespace S4_UIEngine.UI.Elements {
    public abstract class UIElement {
        public Vector2 Size { get; set; }
        public Vector2 Position { get; set; }

        public virtual bool PositionAbsolute { get; set; } = false;

        public bool IsMouseHover => UIEngine.IM.IsMouseInRectangle(new Vector4(Position, Size.X, Size.Y));

        internal virtual void OnMouseClickDown(int mb) { }

        public Effects Effects { get; set; }

        public List<IUIComponent> Components { get; protected set; }
    }
}
