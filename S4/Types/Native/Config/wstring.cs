using Forge.S4.Types;
using Forge.S4.Types.Native.Helpers;

namespace Forge.S4.Types.Native.Config
{
    public unsafe partial struct wstring
    {
        [NativeInheritance(nameof(wstring))]
        [NativeTypeName("wchar_t *")]
        public ushort* text;

        [NativeInheritance(nameof(wstring))]
        public int size;

        [NativeInheritance(nameof(wstring))]
        public int capacity;

        [NativeInheritance(nameof(wstring))]
        public int field_0C;

        [NativeInheritance(nameof(wstring))]
        public int capacity_;

        [NativeInheritance(nameof(wstring))]
        public int field_14;
    }
}
