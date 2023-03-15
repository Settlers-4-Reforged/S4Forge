using System.Numerics;

namespace S4UI.UI.Elements.Grouping {
    internal class UIRows : UIGroup {
        private readonly float rowHeight;
        private readonly int rows;

        public UIRows(float rowHeight) {
            this.rowHeight = rowHeight;
            this.rows = 0;
        }

        public UIRows AddRow(UIElement element) {
            element.Position = Vector2.UnitY * rowHeight * rows;
            Elements.Add(element);

            return this;
        }
    }
}
