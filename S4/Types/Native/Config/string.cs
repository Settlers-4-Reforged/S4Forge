using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Forge.S4.Types.Native.Config {

    [DebuggerDisplay("{Text}")]
    public unsafe partial struct wstring {
        public string Text {
            get {
                fixed (wstring* t = &this) {
                    IntPtr pText;

                    if (field_14 <= 16) {
                        pText = (IntPtr)(&t->text);
                    } else {
                        pText = (IntPtr)t->text;
                    }

                    return Marshal.PtrToStringAnsi(pText) ?? "unknown";
                }
            }
        }
    }
}
