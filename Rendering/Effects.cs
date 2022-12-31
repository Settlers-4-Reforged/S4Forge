using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_UIEngine.Rendering {
    [Flags]
    public enum Effects {
        None = 2 ^ 0,
        Hover = 2 ^ 1,
    }
}
