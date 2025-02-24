using Forge.S4.Types;
using Forge.S4.Types.Native.Helpers;
using System.Runtime.CompilerServices;

namespace Forge.S4.Types.Native.Config
{
    public unsafe partial struct CConfigVar : CConfigVar.Interface
    {
        public void** lpVtbl;

        [NativeInheritance(nameof(CConfigVar))]
        [NativeTypeName("char")]
        public sbyte field_4;

        [NativeInheritance(nameof(CConfigVar))]
        [NativeTypeName("char")]
        public sbyte type;

        [NativeInheritance(nameof(CConfigVar))]
        [NativeTypeName("char")]
        public sbyte itemCount;

        [NativeInheritance(nameof(CConfigVar))]
        [NativeTypeName("char")]
        public sbyte field_7;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public int GetValue()
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVar*, int>)(lpVtbl[0]))((CConfigVar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public double GetValueAsDouble()
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVar*, double>)(lpVtbl[1]))((CConfigVar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("DWORD")]
        public uint ResetString(wstring* name)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVar*, wstring*, uint>)(lpVtbl[2]))((CConfigVar*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public int* GetArray()
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVar*, int*>)(lpVtbl[3]))((CConfigVar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public int* GetList()
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVar*, int*>)(lpVtbl[4]))((CConfigVar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void nullsub_508(int a1)
        {
            ((delegate* unmanaged[Thiscall]<CConfigVar*, int, void>)(lpVtbl[5]))((CConfigVar*)Unsafe.AsPointer(ref this), a1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void nullsub_509(int a1)
        {
            ((delegate* unmanaged[Thiscall]<CConfigVar*, int, void>)(lpVtbl[6]))((CConfigVar*)Unsafe.AsPointer(ref this), a1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void SetValueFromFloat(float value)
        {
            ((delegate* unmanaged[Thiscall]<CConfigVar*, float, void>)(lpVtbl[7]))((CConfigVar*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void SetValueFromInt(int a1)
        {
            ((delegate* unmanaged[Thiscall]<CConfigVar*, int, void>)(lpVtbl[8]))((CConfigVar*)Unsafe.AsPointer(ref this), a1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("DWORD *")]
        public uint* DestroyConfigVar([NativeTypeName("char")] sbyte a2)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVar*, sbyte, uint*>)(lpVtbl[9]))((CConfigVar*)Unsafe.AsPointer(ref this), a2);
        }

        public interface Interface
        {
            [VtblIndex(0)]
            int GetValue();

            [VtblIndex(1)]
            double GetValueAsDouble();

            [VtblIndex(2)]
            [return: NativeTypeName("DWORD")]
            uint ResetString(wstring* name);

            [VtblIndex(3)]
            int* GetArray();

            [VtblIndex(4)]
            int* GetList();

            [VtblIndex(5)]
            void nullsub_508(int a1);

            [VtblIndex(6)]
            void nullsub_509(int a1);

            [VtblIndex(7)]
            void SetValueFromFloat(float value);

            [VtblIndex(8)]
            void SetValueFromInt(int a1);

            [VtblIndex(9)]
            [return: NativeTypeName("DWORD *")]
            uint* DestroyConfigVar([NativeTypeName("char")] sbyte a2);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("int () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int> GetValue;

            [NativeTypeName("double () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, double> GetValueAsDouble;

            [NativeTypeName("DWORD (wstring *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, wstring*, uint> ResetString;

            [NativeTypeName("int *() __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int*> GetArray;

            [NativeTypeName("int *() __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int*> GetList;

            [NativeTypeName("void (int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, void> nullsub_508;

            [NativeTypeName("void (int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, void> nullsub_509;

            [NativeTypeName("void (float) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, float, void> SetValueFromFloat;

            [NativeTypeName("void (int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, void> SetValueFromInt;

            [NativeTypeName("DWORD *(char) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte, uint*> DestroyConfigVar;
        }
    }
}
