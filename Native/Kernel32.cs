using System;
using System.Runtime.InteropServices;

namespace Forge.UX.Native {
    public static class Kernel32 {
        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr GetProcAddress(IntPtr/*HMODULE*/ hModule, string procName);

        [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr/*HMODULE*/ LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpFileName);

        [DllImport("kernel32.dll")]
        public static extern int GetModuleHandleA(IntPtr name);
    }
}
