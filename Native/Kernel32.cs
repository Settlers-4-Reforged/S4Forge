using System;
using System.Runtime.InteropServices;

namespace S4_UIEngine.Native {
    internal static class Kernel32 {
        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        internal static extern IntPtr GetProcAddress(IntPtr/*HMODULE*/ hModule, string procName);

        [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Ansi)]
        internal static extern IntPtr/*HMODULE*/ LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    }
}
