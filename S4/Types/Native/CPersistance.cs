using Forge.S4.Types;
using Forge.S4.Types.Native.Helpers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Forge.S4.Types.Native
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct CPersistance : CPersistance.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("LPVOID")]
        public void* vfunc0()
        {
            return ((delegate* unmanaged[Thiscall]<CPersistance*, void*>)(lpVtbl[0]))((CPersistance*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void serialize([NativeTypeName("DWORD *")] uint* param0)
        {
            ((delegate* unmanaged[Thiscall]<CPersistance*, uint*, void>)(lpVtbl[1]))((CPersistance*)Unsafe.AsPointer(ref this), param0);
        }

        public interface Interface
        {
            [VtblIndex(0)]
            [return: NativeTypeName("LPVOID")]
            void* vfunc0();

            [VtblIndex(1)]
            void serialize([NativeTypeName("DWORD *")] uint* param0);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("LPVOID () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void*> vfunc0;

            [NativeTypeName("void (DWORD *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint*, void> serialize;
        }
    }
}
