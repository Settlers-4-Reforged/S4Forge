using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Forge.Native {
    internal class User32 {
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        public static void MessageBox(string text, string caption) {
            MessageBox(IntPtr.Zero, text, caption, 0);
        }
    }
}
