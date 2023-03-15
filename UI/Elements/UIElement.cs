using S4UI.Rendering;
using S4UI.UI.Components;

using System.Collections.Generic;
using System.Numerics;

namespace S4UI.UI.Elements {
    public abstract class UIElement {
        public Vector2 Size { get; set; }
        public Vector2 Position { get; set; }

        public virtual bool PositionAbsolute { get; set; } = false;

        ///<summary>The lower the further behind: 0 &lt; 100 &lt; 1000</summary>
        public int ZIndex = 0;

        public bool IsMouseHover => UIEngine.IM.IsMouseInRectangle(new Vector4(Position, Size.X, Size.Y));

        internal virtual void OnMouseClickDown(int mb) { }
        internal virtual void OnMouseClickUp(int mb) { }

        internal virtual void OnMouseEnter() { }
        internal virtual void OnMouseLeave() { }


        public Effects Effects { get; set; }

        public virtual List<IUIComponent> Components { get; protected set; }
    }
}
