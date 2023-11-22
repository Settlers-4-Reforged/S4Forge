using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Forge.Native {
    public class User32 {
        public struct Pos {
            public long X;
            public long Y;
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetCursorPos(out Pos lpPoint);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        public static void MessageBox(string text, string caption) {
            MessageBox(IntPtr.Zero, text, caption, 0);
        }

        internal static void RegisterWndProc() {
            unsafe {
                ModAPI.API.AddWndProc(((_, msg, param, lParam) => {

                    var winMains = WndProc?.GetInvocationList();

                    if (winMains == null) return 0;
                    foreach (Delegate? winMain in winMains) {
                        if (winMain is not Func<WndProcMsg, IntPtr, IntPtr, bool> func) continue;

                        if (func((WndProcMsg)msg, new IntPtr(param), new IntPtr(lParam))) {
                            return 0;
                        }
                    }

                    return 0;
                }));
            }


        }

        public static Func<WndProcMsg, IntPtr, IntPtr, bool>? WndProc { get; set; }
    }
}
