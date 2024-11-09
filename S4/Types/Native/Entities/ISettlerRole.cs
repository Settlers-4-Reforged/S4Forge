using Forge.S4.Types;
using Forge.S4.Types.Native.Helpers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Forge.S4.Types.Native.Entities
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [NativeTypeName("struct ISettlerRole : CPersistance")]
    [NativeInheritance(nameof(CPersistance))]
    public unsafe partial struct ISettlerRole : ISettlerRole.Interface
    {
        public void** lpVtbl;

        [NativeInheritance(nameof(ISettlerRole))]
        [NativeTypeName("CHAR")]
        private sbyte unk_04;

        [NativeInheritance(nameof(ISettlerRole))]
        private byte unk_05;

        [NativeInheritance(nameof(ISettlerRole))]
        private byte walkspeed;

        [NativeInheritance(nameof(ISettlerRole))]
        private byte unk_07;

        [NativeInheritance(nameof(ISettlerRole))]
        [NativeTypeName("WORD")]
        private ushort unk_08;

        [NativeInheritance(nameof(ISettlerRole))]
        private byte unk_0A;

        [NativeInheritance(nameof(ISettlerRole))]
        private byte unk_0B;

        [NativeInheritance(nameof(ISettlerRole))]
        private byte unk_0C;

        [NativeInheritance(nameof(ISettlerRole))]
        private byte pad_0D;

        [NativeInheritance(nameof(ISettlerRole))]
        [NativeTypeName("WORD")]
        private ushort unk_0E;

        [NativeInheritance(nameof(ISettlerRole))]
        [NativeTypeName("WORD")]
        private ushort unk_10;

        [NativeInheritance(nameof(ISettlerRole))]
        [NativeTypeName("WORD")]
        private ushort unk_12;

        [NativeInheritance(nameof(ISettlerRole))]
        [NativeTypeName("WORD")]
        private ushort unk_14;

        [NativeInheritance(nameof(ISettlerRole))]
        [NativeTypeName("WORD")]
        private ushort pad_16;

        [NativeInheritance(nameof(ISettlerRole))]
        [NativeTypeName("DWORD")]
        private uint unk_18;

        [NativeInheritance(nameof(ISettlerRole))]
        [NativeTypeName("DWORD")]
        private uint unk_1C;

        [NativeInheritance(nameof(ISettlerRole))]
        [NativeTypeName("WORD")]
        private ushort unk_20;

        [NativeInheritance(nameof(ISettlerRole))]
        [NativeTypeName("WORD")]
        private ushort unk_22;

        [NativeInheritance(nameof(ISettlerRole))]
        [NativeTypeName("WORD")]
        private ushort unk_24;

        [NativeInheritance(nameof(ISettlerRole))]
        [NativeTypeName("WORD")]
        private ushort unk_26;

        [NativeInheritance(nameof(ISettlerRole))]
        [NativeTypeName("WORD")]
        private ushort unk_28;

        [NativeInheritance(nameof(ISettlerRole))]
        [NativeTypeName("WORD")]
        private ushort unk_2A;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("LPVOID")]
        public void* vfunc0()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, void*>)(lpVtbl[0]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void serialize([NativeTypeName("DWORD *")] uint* param0)
        {
            ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint*, void>)(lpVtbl[1]))((ISettlerRole*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public ISettlerRole* vfunc2(byte param0)
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, byte, ISettlerRole*>)(lpVtbl[2]))((ISettlerRole*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc3()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint>)(lpVtbl[3]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void walk([NativeTypeName("LPVOID")] void* param0)
        {
            ((delegate* unmanaged[Thiscall]<ISettlerRole*, void*, void>)(lpVtbl[4]))((ISettlerRole*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc5()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint>)(lpVtbl[5]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void vfunc6([NativeTypeName("LPVOID")] void* param0)
        {
            ((delegate* unmanaged[Thiscall]<ISettlerRole*, void*, void>)(lpVtbl[6]))((ISettlerRole*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc7()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint>)(lpVtbl[7]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void vfunc8()
        {
            ((delegate* unmanaged[Thiscall]<ISettlerRole*, void>)(lpVtbl[8]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc9()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint>)(lpVtbl[9]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc10()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint>)(lpVtbl[10]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc11()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint>)(lpVtbl[11]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void vfunc12([NativeTypeName("WORD")] ushort param0)
        {
            ((delegate* unmanaged[Thiscall]<ISettlerRole*, ushort, void>)(lpVtbl[12]))((ISettlerRole*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void vfunc13([NativeTypeName("WORD")] ushort param0)
        {
            ((delegate* unmanaged[Thiscall]<ISettlerRole*, ushort, void>)(lpVtbl[13]))((ISettlerRole*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc14()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint>)(lpVtbl[14]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc15(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, int, uint>)(lpVtbl[15]))((ISettlerRole*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc16(int* param0)
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, int*, uint>)(lpVtbl[16]))((ISettlerRole*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc17([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint, uint>)(lpVtbl[17]))((ISettlerRole*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc18()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint>)(lpVtbl[18]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public byte vfunc19()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, byte>)(lpVtbl[19]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void vfunc20(int param0, [NativeTypeName("WORD")] ushort param1)
        {
            ((delegate* unmanaged[Thiscall]<ISettlerRole*, int, ushort, void>)(lpVtbl[20]))((ISettlerRole*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc21(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, int, uint>)(lpVtbl[21]))((ISettlerRole*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc22()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint>)(lpVtbl[22]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc23()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint>)(lpVtbl[23]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc24()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint>)(lpVtbl[24]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc25()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint>)(lpVtbl[25]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc26()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint>)(lpVtbl[26]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc27()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint>)(lpVtbl[27]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc28()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, uint>)(lpVtbl[28]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public byte vfunc29()
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, byte>)(lpVtbl[29]))((ISettlerRole*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc30(int param0, int param1)
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, int, int, uint>)(lpVtbl[30]))((ISettlerRole*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public byte vfunc31([NativeTypeName("LPVOID")] void* param0)
        {
            return ((delegate* unmanaged[Thiscall]<ISettlerRole*, void*, byte>)(lpVtbl[31]))((ISettlerRole*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public void vfunc32(int param0, int** param1, [NativeTypeName("WORD")] ushort param2, [NativeTypeName("WORD")] ushort param3, [NativeTypeName("DWORD")] uint param4)
        {
            ((delegate* unmanaged[Thiscall]<ISettlerRole*, int, int**, ushort, ushort, uint, void>)(lpVtbl[32]))((ISettlerRole*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        public interface Interface : CPersistance.Interface
        {
            [VtblIndex(2)]
            ISettlerRole* vfunc2(byte param0);

            [VtblIndex(3)]
            [return: NativeTypeName("DWORD")]
            uint vfunc3();

            [VtblIndex(4)]
            void walk([NativeTypeName("LPVOID")] void* param0);

            [VtblIndex(5)]
            [return: NativeTypeName("DWORD")]
            uint vfunc5();

            [VtblIndex(6)]
            void vfunc6([NativeTypeName("LPVOID")] void* param0);

            [VtblIndex(7)]
            [return: NativeTypeName("DWORD")]
            uint vfunc7();

            [VtblIndex(8)]
            void vfunc8();

            [VtblIndex(9)]
            [return: NativeTypeName("DWORD")]
            uint vfunc9();

            [VtblIndex(10)]
            [return: NativeTypeName("DWORD")]
            uint vfunc10();

            [VtblIndex(11)]
            [return: NativeTypeName("DWORD")]
            uint vfunc11();

            [VtblIndex(12)]
            void vfunc12([NativeTypeName("WORD")] ushort param0);

            [VtblIndex(13)]
            void vfunc13([NativeTypeName("WORD")] ushort param0);

            [VtblIndex(14)]
            [return: NativeTypeName("DWORD")]
            uint vfunc14();

            [VtblIndex(15)]
            [return: NativeTypeName("DWORD")]
            uint vfunc15(int param0);

            [VtblIndex(16)]
            [return: NativeTypeName("DWORD")]
            uint vfunc16(int* param0);

            [VtblIndex(17)]
            [return: NativeTypeName("DWORD")]
            uint vfunc17([NativeTypeName("DWORD")] uint param0);

            [VtblIndex(18)]
            [return: NativeTypeName("DWORD")]
            uint vfunc18();

            [VtblIndex(19)]
            byte vfunc19();

            [VtblIndex(20)]
            void vfunc20(int param0, [NativeTypeName("WORD")] ushort param1);

            [VtblIndex(21)]
            [return: NativeTypeName("DWORD")]
            uint vfunc21(int param0);

            [VtblIndex(22)]
            [return: NativeTypeName("DWORD")]
            uint vfunc22();

            [VtblIndex(23)]
            [return: NativeTypeName("DWORD")]
            uint vfunc23();

            [VtblIndex(24)]
            [return: NativeTypeName("DWORD")]
            uint vfunc24();

            [VtblIndex(25)]
            [return: NativeTypeName("DWORD")]
            uint vfunc25();

            [VtblIndex(26)]
            [return: NativeTypeName("DWORD")]
            uint vfunc26();

            [VtblIndex(27)]
            [return: NativeTypeName("DWORD")]
            uint vfunc27();

            [VtblIndex(28)]
            [return: NativeTypeName("DWORD")]
            uint vfunc28();

            [VtblIndex(29)]
            byte vfunc29();

            [VtblIndex(30)]
            [return: NativeTypeName("DWORD")]
            uint vfunc30(int param0, int param1);

            [VtblIndex(31)]
            byte vfunc31([NativeTypeName("LPVOID")] void* param0);

            [VtblIndex(32)]
            void vfunc32(int param0, int** param1, [NativeTypeName("WORD")] ushort param2, [NativeTypeName("WORD")] ushort param3, [NativeTypeName("DWORD")] uint param4);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("LPVOID () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void*> vfunc0;

            [NativeTypeName("void (DWORD *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint*, void> serialize;

            [NativeTypeName("ISettlerRole *(BYTE) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, byte, ISettlerRole*> vfunc2;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc3;

            [NativeTypeName("void (LPVOID) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void*, void> walk;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc5;

            [NativeTypeName("void (LPVOID) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void*, void> vfunc6;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc7;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc8;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc9;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc10;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc11;

            [NativeTypeName("void (WORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, ushort, void> vfunc12;

            [NativeTypeName("void (WORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, ushort, void> vfunc13;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc14;

            [NativeTypeName("DWORD (INT) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, uint> vfunc15;

            [NativeTypeName("DWORD (INT *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int*, uint> vfunc16;

            [NativeTypeName("DWORD (DWORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint, uint> vfunc17;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc18;

            [NativeTypeName("BYTE () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, byte> vfunc19;

            [NativeTypeName("void (INT, WORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, ushort, void> vfunc20;

            [NativeTypeName("DWORD (INT) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, uint> vfunc21;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc22;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc23;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc24;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc25;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc26;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc27;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc28;

            [NativeTypeName("BYTE () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, byte> vfunc29;

            [NativeTypeName("DWORD (INT, INT) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int, uint> vfunc30;

            [NativeTypeName("BYTE (LPVOID) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void*, byte> vfunc31;

            [NativeTypeName("void (INT, INT **, WORD, WORD, DWORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int**, ushort, ushort, uint, void> vfunc32;
        }
    }
}
