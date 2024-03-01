using Forge.Native;
using Forge.S4.Types.Native.UI;
using Forge.UX.Native;

using System;
using System.Runtime.InteropServices;

namespace Forge.S4 {
    public static class GameValues {
        static GameValues() {
            S4_Main = Kernel32.GetModuleHandleA(IntPtr.Zero);
        }

        public static IntPtr Hwnd {
            get {
                unsafe {
                    return new IntPtr(ModAPI.API.GetHwnd());
                }
            }
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


        /// <summary>
        /// Creates a copy to a UI Element from a container
        /// </summary>
        /// <param name="container"></param>
        /// <param name="valueLink"></param>
        /// <returns></returns>
        public static S4UIElement? GetUIElementFromIndex(int container, int valueLink) {
            unsafe {
                var element = GetUIElementFromIndexUnsafe(container, valueLink);
                return element == null ? null : *element;
            }
        }

        public static unsafe S4UIElement* GetUIElementFromIndexUnsafe(int container, int valueLink) {
            Int32 UIMenus = GameValues.ReadValue<Int32>(0x1064C94);


            Int32 containerOffset = GameValues.ReadValue<Int32>(UIMenus + (container + 4) * 4, false);
            Int32 elementsOffset = GameValues.ReadValue<Int32>(containerOffset + UIMenus, false);
            Int16 elementCount = GameValues.ReadValue<Int16>(containerOffset + UIMenus + 12, false);
            S4UIElement* elementArrayPointer =
                (S4UIElement*)new IntPtr(containerOffset + UIMenus + 16).ToPointer();

            int i = 0;
            while (valueLink != elementArrayPointer->valueLink) {
                i++;
                elementArrayPointer++;

                if (i >= elementCount)
                    return null;
            }

            return elementArrayPointer;
        }

        public static unsafe S4UIElement*[] GetAllUIElementsFromIndexUnsafe(int container) {
            Int32 UIMenus = GameValues.ReadValue<Int32>(0x1064C94);


            Int32 containerOffset = GameValues.ReadValue<Int32>(UIMenus + (container + 4) * 4, false);
            Int32 elementsOffset = GameValues.ReadValue<Int32>(containerOffset + UIMenus, false);
            Int16 elementCount = GameValues.ReadValue<Int16>(containerOffset + UIMenus + 12, false);
            S4UIElement* elementArrayPointer =
                (S4UIElement*)new IntPtr(containerOffset + UIMenus + 16).ToPointer();

            S4UIElement*[] elements = new S4UIElement*[elementCount];

            int i = 0;
            while (i < elementCount) {
                elements[i] = elementArrayPointer;

                i++;
                elementArrayPointer++;
            }

            return elements;
        }
    }
}
