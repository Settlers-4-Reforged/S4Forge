using S4UI.Native;
using System;
using System.Numerics;

namespace S4UI.S4.Managers {
    public interface IInputManager {
        //Mouse:
        bool IsMouseInRectangle(Vector4 rect);
        float GetMouseScroll();

        //Key related input:
        bool IsKeyDown(Keys key);
        bool IsKeyUp(Keys key);
        bool IsKeyHeld(Keys key);

        //Original Game Input Blocking:
        void ClearBlockFlags();
        void BlockInput(EventBlockFlags flags);
    }

    [Flags]
    public enum EventBlockFlags : int {
        None = 0b0000_0000,
        MouseClick = 0b0000_0001,
        MouseWheel = 0b0000_0010,
        Mouse = 0b0000_0100,
        Keyboard = 0b0000_1000,
        All = 0b1111_1111
    }
}
