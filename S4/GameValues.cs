using Forge.UX.Native;

using System;
using System.Runtime.InteropServices;

namespace Forge.S4 {
    public static class GameValues {
        static GameValues() {
            S4_Main = Kernel32.GetModuleHandleA(IntPtr.Zero);
        }

        public static int S4_Main { get; private set; }

        public static T ReadValue<T>(int address, bool relative = true) where T : unmanaged {
            int pointer = address + (relative ? S4_Main : 0);

            unsafe {
                T* value = (T*)new IntPtr(pointer).ToPointer();

                return *value;
            }
        }

        public static unsafe T* GetPointer<T>(int address, bool relative = true) where T : unmanaged {
            return (T*)(address + (relative ? S4_Main : 0));
        }

        public static string? ReadStringFromUITable(int id) {
            const int uiStringTable = 0x1065218;
            int address = S4_Main + uiStringTable + (id * 300);

            return Marshal.PtrToStringAnsi(new IntPtr(address));
        }
        public static IntPtr GetStringUITableAddress(int id) {
            const int uiStringTable = 0x1065218;
            int address = S4_Main + uiStringTable + (id * 300);

            return new IntPtr(address);
        }
    }
}
