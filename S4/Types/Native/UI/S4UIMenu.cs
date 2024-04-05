using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Forge.S4.Types.Native.UI {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct S4UIMenu {
        ushort type;
        ushort x;
        ushort y;
        ushort width;
        ushort height;
        ushort mainTexture;
        ushort transparency;
        ushort containerPointer;
        //sizeof == 36
    }
}
