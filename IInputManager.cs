using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace S4_UIEngine {
    public interface IInputManager {
        bool IsMouseInRectangle(Vector4 rect);
    }
}
