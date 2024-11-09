using Forge.S4.Types;
using Forge.S4.Types.Native.Helpers;
using System.Runtime.CompilerServices;

namespace Forge.S4.Types.Native.Entities
{
    public unsafe partial struct CWarriorBehaviour : CWarriorBehaviour.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public void warriorfunc0(int param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2)
        {
            ((delegate* unmanaged[Thiscall]<CWarriorBehaviour*, int, void*, uint, void>)(lpVtbl[0]))((CWarriorBehaviour*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("DWORD")]
        public uint warriorfunc1()
        {
            return ((delegate* unmanaged[Thiscall]<CWarriorBehaviour*, uint>)(lpVtbl[1]))((CWarriorBehaviour*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("DWORD")]
        public uint warriorfunc2()
        {
            return ((delegate* unmanaged[Thiscall]<CWarriorBehaviour*, uint>)(lpVtbl[2]))((CWarriorBehaviour*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void warriorfunc3([NativeTypeName("LPVOID")] void* param0, int param1)
        {
            ((delegate* unmanaged[Thiscall]<CWarriorBehaviour*, void*, int, void>)(lpVtbl[3]))((CWarriorBehaviour*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void warriorfunc4()
        {
            ((delegate* unmanaged[Thiscall]<CWarriorBehaviour*, void>)(lpVtbl[4]))((CWarriorBehaviour*)Unsafe.AsPointer(ref this));
        }

        public interface Interface
        {
            [VtblIndex(0)]
            void warriorfunc0(int param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2);

            [VtblIndex(1)]
            [return: NativeTypeName("DWORD")]
            uint warriorfunc1();

            [VtblIndex(2)]
            [return: NativeTypeName("DWORD")]
            uint warriorfunc2();

            [VtblIndex(3)]
            void warriorfunc3([NativeTypeName("LPVOID")] void* param0, int param1);

            [VtblIndex(4)]
            void warriorfunc4();
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("void (INT, LPVOID, DWORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, void*, uint, void> warriorfunc0;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> warriorfunc1;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> warriorfunc2;

            [NativeTypeName("void (LPVOID, INT) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void*, int, void> warriorfunc3;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> warriorfunc4;
        }
    }
}
