using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Forge.Native {
    public class User32 {
        public struct Pos {
            public int X;
            public int Y;
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetCursorPos(out Pos lpPoint);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool ScreenToClient(IntPtr hWnd, ref Pos lpPoint);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        public static void MessageBox(string text, string caption) {
            MessageBox(IntPtr.Zero, text, caption, 0);
        }

        private static bool registeredWndProc = false;
        internal static void RegisterWndProc() {
            if (registeredWndProc) return;
            registeredWndProc = true;

            unsafe {
                ModAPI.API.AddWndProc(((_, msg, param, lParam) => {

#pragma warning disable CS0618 // Type or member is obsolete
                    var winMains = WndProc?.GetInvocationList();
#pragma warning restore CS0618 // Type or member is obsolete

                    if (winMains == null) return 0;
                    foreach (WndProcDelegate winMain in winMains) {
                        if (winMain((WndProcMsg)msg, new UIntPtr(param), new UIntPtr((uint)lParam))) {
                            return 0;
                        }
                    }

                    return 0;
                }));
            }


        }

        /// <summary>
        /// The WndProc delegate is called for every message that is sent to the game window.
        /// </summary>
        /// <returns>
        /// Return true if the message was handled, false otherwise.
        /// <br/>
        /// When returning true, the message will not be processed by the game or any other callback further down the chain.
        /// </returns>
        public delegate bool WndProcDelegate(WndProcMsg msg, UIntPtr wParam, UIntPtr lParam);

        [Obsolete("Use functionality provided by other engines or functions (like the UXEngine) instead.")]
        private static WndProcDelegate? WndProc { get; set; }

        public static void AddWndProc(WndProcDelegate wndProc) {
            RegisterWndProc();
            WndProc += wndProc;
        }
    }
}
