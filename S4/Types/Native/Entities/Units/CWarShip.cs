using Forge.S4.Types;
using Forge.S4.Types.Native.Helpers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Forge.S4.Types.Native.Entities
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [NativeTypeName("struct CWarShip : CShip, CWarriorBehaviour")]
    [NativeInheritance(nameof(CShip))]
    [NativeInheritance(nameof(CWarriorBehaviour))]
    public unsafe partial struct CWarShip : CWarShip.Interface
    {
        public void** lpVtbl_Base1;

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("DWORD")]
        public uint id;

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("WORD")]
        public ushort id2;

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("enum EntityType")]
        public IEntity.EntityType entityType;

        [NativeInheritance(nameof(IEntity))]
        public byte unk0;

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("WORD")]
        public ushort objectId;

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("BYTE[6]")]
        public fixed byte unk1[6];

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("enum BaseType")]
        public IEntity.BaseType baseType;

        [NativeInheritance(nameof(IEntity))]
        public byte selectionFlags;

        [NativeInheritance(nameof(IEntity))]
        public byte unk2;

        [NativeInheritance(nameof(IEntity))]
        public byte unk3;

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("WORD")]
        public ushort x;

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("WORD")]
        public ushort y;

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("DWORD")]
        public uint unk5;

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("__AnonymousRecord_entities_L108_C17")]
        public IEntity._Anonymous_e__Struct Anonymous;

        [NativeInheritance(nameof(IEntity))]
        public byte health;

        [NativeInheritance(nameof(IEntity))]
        public byte pad0;

        [NativeInheritance(nameof(IEntity))]
        public byte pad1;

        public byte tribe
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.tribe;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.tribe = value;
            }
        }

        public byte player
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.player;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.player = value;
            }
        }

        [NativeInheritance(nameof(IAnimatedEntity))]
        public byte unk6;

        [NativeInheritance(nameof(IAnimatedEntity))]
        public byte unk7;

        [NativeInheritance(nameof(IAnimatedEntity))]
        [NativeTypeName("WORD")]
        public ushort unk8;

        [NativeInheritance(nameof(IAnimatedEntity))]
        [NativeTypeName("WORD")]
        public ushort unk9;

        [NativeInheritance(nameof(IAnimatedEntity))]
        [NativeTypeName("WORD")]
        public ushort unk10;

        [NativeInheritance(nameof(IAnimatedEntity))]
        [NativeTypeName("DWORD")]
        public uint unk11;

        [NativeInheritance(nameof(IAnimatedEntity))]
        [NativeTypeName("DWORD")]
        public uint unk12;

        [NativeInheritance(nameof(IAnimatedEntity))]
        public int unk13;

        [NativeInheritance(nameof(IAnimatedEntity))]
        public int unk14;

        [NativeInheritance(nameof(IMovingEntity))]
        [NativeTypeName("DWORD")]
        public uint unk15;

        [NativeInheritance(nameof(IMovingEntity))]
        [NativeTypeName("CHAR")]
        public sbyte unk16;

        [NativeInheritance(nameof(IMovingEntity))]
        public byte unk17;

        [NativeInheritance(nameof(IMovingEntity))]
        public byte unk18;

        [NativeInheritance(nameof(IMovingEntity))]
        public byte pad2;

        [NativeInheritance(nameof(IMovingEntity))]
        [NativeTypeName("WORD")]
        public ushort unk19;

        [NativeInheritance(nameof(IMovingEntity))]
        [NativeTypeName("WORD")]
        public ushort unk20;

        [NativeInheritance(nameof(IMovingEntity))]
        [NativeTypeName("DWORD")]
        public uint unk21;

        [NativeInheritance(nameof(IMovingEntity))]
        [NativeTypeName("DWORD")]
        public uint unk22;

        [NativeInheritance(nameof(IMovingEntity))]
        [NativeTypeName("LPVOID")]
        public void* unk23;

        [NativeInheritance(nameof(IMovingEntity))]
        [NativeTypeName("DWORD")]
        public uint unk24;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("LPVOID")]
        public void* unk25;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk26;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk27;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk28;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk29;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk30;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk31;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk32;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk33;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk34;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk35;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("WORD")]
        public ushort unk36;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("DWORD")]
        public uint unk37;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk38;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk39;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk40;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk41;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("WORD")]
        public ushort unk42;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("WORD")]
        public ushort unk43;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("WORD")]
        public ushort unk44;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("WORD")]
        public ushort unk45;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("WORD")]
        public ushort unk46;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("BYTE[6]")]
        public fixed byte unk47[6];

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("INT32")]
        public int unk48;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("INT32")]
        public int unk49;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("DWORD")]
        public uint unk50;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("DWORD")]
        public uint unk51;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("DWORD")]
        public uint unk52;

        [NativeInheritance(nameof(CShip))]
        [NativeTypeName("DWORD")]
        private uint unk53;

        public void** lpVtbl_Base2;

        [NativeInheritance(nameof(CWarShip))]
        [NativeTypeName("DWORD")]
        public uint unk54;

        [NativeInheritance(nameof(CWarShip))]
        [NativeTypeName("DWORD")]
        public uint unk55;

        [NativeInheritance(nameof(CWarShip))]
        [NativeTypeName("DWORD")]
        public uint unk56;

        [NativeInheritance(nameof(CWarShip))]
        [NativeTypeName("DWORD")]
        public uint unk57;

        [NativeInheritance(nameof(CWarShip))]
        [NativeTypeName("DWORD")]
        public uint unk58;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("LPVOID")]
        public void* vfunc0()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, void*>)(lpVtbl_Base1[0]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void serialize([NativeTypeName("DWORD *")] uint* param0)
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, uint*, void>)(lpVtbl_Base1[1]))((CWarShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public IEntity* vfunc2([NativeTypeName("LPVOID")] void* param0)
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, void*, IEntity*>)(lpVtbl_Base1[2]))((CWarShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        public uint clearSelection()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, uint>)(lpVtbl_Base1[3]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void vfunc4()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[4]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("LPVOID")]
        public void* vfunc5()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, void*>)(lpVtbl_Base1[5]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc6(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, int, uint>)(lpVtbl_Base1[6]))((CWarShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void vfunc7([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1)
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, uint, uint, void>)(lpVtbl_Base1[7]))((CWarShip*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void vfunc8([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, uint, void>)(lpVtbl_Base1[8]))((CWarShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void vfunc9()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[9]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc10()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, uint>)(lpVtbl_Base1[10]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc11()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, uint>)(lpVtbl_Base1[11]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void vfunc12()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[12]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void vfunc13(int param0)
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, int, void>)(lpVtbl_Base1[13]))((CWarShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public void vfunc14()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[14]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc15()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, uint>)(lpVtbl_Base1[15]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc16()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, uint>)(lpVtbl_Base1[16]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void vfunc17(int param0, int param1)
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, int, int, void>)(lpVtbl_Base1[17]))((CWarShip*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc18(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, int, uint>)(lpVtbl_Base1[18]))((CWarShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void vfunc19()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[19]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void vfunc20([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, uint, void>)(lpVtbl_Base1[20]))((CWarShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc21()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, uint>)(lpVtbl_Base1[21]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc22()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, uint>)(lpVtbl_Base1[22]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc23()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, uint>)(lpVtbl_Base1[23]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc24()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, uint>)(lpVtbl_Base1[24]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public void vfunc25()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[25]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public void vfunc26()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[26]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public void vfunc27([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, uint, void>)(lpVtbl_Base1[27]))((CWarShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public void vfunc28([NativeTypeName("LPVOID")] void* param0, [NativeTypeName("WORD")] ushort param1)
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void*, ushort, void>)(lpVtbl_Base1[28]))((CWarShip*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public byte vfunc29()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, byte>)(lpVtbl_Base1[29]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public void vfunc30()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[30]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public void vfunc31()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[31]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public void vfunc32()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[32]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public void vfunc33()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[33]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public void vfunc34()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[34]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc35()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, uint>)(lpVtbl_Base1[35]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public void vfunc36()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[36]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public void vfunc37()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[37]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public void vfunc38()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[38]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public void vfunc39(int param0)
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, int, void>)(lpVtbl_Base1[39]))((CWarShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public void vfunc40()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[40]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public void vfunc41([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, uint, void>)(lpVtbl_Base1[41]))((CWarShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public void vfunc42([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, uint, void>)(lpVtbl_Base1[42]))((CWarShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public void vfunc43()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[43]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public void vfunc44()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[44]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public void vfunc45()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[45]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public void vfunc46()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[46]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public void vfunc47()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[47]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public void vfunc48()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[48]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public void vfunc49([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, uint, void>)(lpVtbl_Base1[49]))((CWarShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public void vfunc50([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, uint, void>)(lpVtbl_Base1[50]))((CWarShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public byte vfunc51()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, byte>)(lpVtbl_Base1[51]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc52()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, uint>)(lpVtbl_Base1[52]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public void vfunc53()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base1[53]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public void vfunc54([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, uint, void>)(lpVtbl_Base1[54]))((CWarShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public void warriorfunc0(int param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2)
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, int, void*, uint, void>)(lpVtbl_Base2[0]))((CWarShip*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("DWORD")]
        public uint warriorfunc1()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, uint>)(lpVtbl_Base2[1]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("DWORD")]
        public uint warriorfunc2()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, uint>)(lpVtbl_Base2[2]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void warriorfunc3([NativeTypeName("LPVOID")] void* param0, int param1)
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void*, int, void>)(lpVtbl_Base2[3]))((CWarShip*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void warriorfunc4()
        {
            ((delegate* unmanaged[Thiscall]<CWarShip*, void>)(lpVtbl_Base2[4]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc55()
        {
            return ((delegate* unmanaged[Thiscall]<CWarShip*, uint>)(lpVtbl_Base1[55]))((CWarShip*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : CShip.Interface, CWarriorBehaviour.Interface
        {
            [VtblIndex(55)]
            [return: NativeTypeName("DWORD")]
            uint vfunc55();
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("LPVOID () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void*> vfunc0;

            [NativeTypeName("void (DWORD *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint*, void> serialize;

            [NativeTypeName("IEntity *(LPVOID) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void*, IEntity*> vfunc2;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> clearSelection;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc4;

            [NativeTypeName("LPVOID () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void*> vfunc5;

            [NativeTypeName("DWORD (INT) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, uint> vfunc6;

            [NativeTypeName("void (DWORD, DWORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint, uint, void> vfunc7;

            [NativeTypeName("void (DWORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint, void> vfunc8;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc9;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc10;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc11;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc12;

            [NativeTypeName("void (INT) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, void> vfunc13;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc14;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc15;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc16;

            [NativeTypeName("void (INT, INT) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int, void> vfunc17;

            [NativeTypeName("DWORD (INT) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, uint> vfunc18;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc19;

            [NativeTypeName("void (DWORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint, void> vfunc20;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc21;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc22;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc23;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc24;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc25;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc26;

            [NativeTypeName("void (DWORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint, void> vfunc27;

            [NativeTypeName("void (LPVOID, WORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void*, ushort, void> vfunc28;

            [NativeTypeName("BYTE () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, byte> vfunc29;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc30;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc31;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc32;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc33;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc34;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc35;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc36;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc37;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc38;

            [NativeTypeName("void (INT) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, void> vfunc39;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc40;

            [NativeTypeName("void (DWORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint, void> vfunc41;

            [NativeTypeName("void (DWORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint, void> vfunc42;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc43;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc44;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc45;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc46;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc47;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc48;

            [NativeTypeName("void (DWORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint, void> vfunc49;

            [NativeTypeName("void (DWORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint, void> vfunc50;

            [NativeTypeName("BYTE () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, byte> vfunc51;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc52;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc53;

            [NativeTypeName("void (DWORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint, void> vfunc54;

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

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc55;
        }
    }
}
