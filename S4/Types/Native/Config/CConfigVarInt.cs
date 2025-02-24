using Forge.S4.Types;
using Forge.S4.Types.Native.Helpers;
using System.Runtime.CompilerServices;

namespace Forge.S4.Types.Native.Config
{
    [NativeTypeName("struct CConfigVarInt : CDynamicConfigVar")]
    [NativeInheritance(nameof(CDynamicConfigVar))]
    public unsafe partial struct CConfigVarInt : CConfigVarInt.Interface
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

        [NativeInheritance(nameof(CConfigVarInt))]
        public int value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public int GetValue()
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVarInt*, int>)(lpVtbl[0]))((CConfigVarInt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public double GetValueAsDouble()
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVarInt*, double>)(lpVtbl[1]))((CConfigVarInt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("DWORD")]
        public uint ResetString(wstring* name)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVarInt*, wstring*, uint>)(lpVtbl[2]))((CConfigVarInt*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public int* GetArray()
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVarInt*, int*>)(lpVtbl[3]))((CConfigVarInt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public int* GetList()
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVarInt*, int*>)(lpVtbl[4]))((CConfigVarInt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void nullsub_508(int a1)
        {
            ((delegate* unmanaged[Thiscall]<CConfigVarInt*, int, void>)(lpVtbl[5]))((CConfigVarInt*)Unsafe.AsPointer(ref this), a1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void nullsub_509(int a1)
        {
            ((delegate* unmanaged[Thiscall]<CConfigVarInt*, int, void>)(lpVtbl[6]))((CConfigVarInt*)Unsafe.AsPointer(ref this), a1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void SetValueFromFloat(float value)
        {
            ((delegate* unmanaged[Thiscall]<CConfigVarInt*, float, void>)(lpVtbl[7]))((CConfigVarInt*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void SetValueFromInt(int a1)
        {
            ((delegate* unmanaged[Thiscall]<CConfigVarInt*, int, void>)(lpVtbl[8]))((CConfigVarInt*)Unsafe.AsPointer(ref this), a1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("DWORD *")]
        public uint* DestroyConfigVar([NativeTypeName("char")] sbyte a2)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigVarInt*, sbyte, uint*>)(lpVtbl[9]))((CConfigVarInt*)Unsafe.AsPointer(ref this), a2);
        }

        public interface Interface : CDynamicConfigVar.Interface
        {
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
