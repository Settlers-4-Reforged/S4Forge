using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Forge.S4.Types.Native {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public unsafe struct Event {
        void* __vftable /*VFT*/;
        EventType eventType;
        uint wparam;
        uint lparam;
        uint eventEngineAttribute;
        byte unknown;
    }
}
