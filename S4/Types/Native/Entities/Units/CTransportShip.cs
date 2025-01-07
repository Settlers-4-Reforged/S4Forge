using Forge.S4.Types;
using Forge.S4.Types.Native.Helpers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Forge.S4.Types.Native.Entities
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [NativeTypeName("struct CTransportShip : CShip")]
    [NativeInheritance(nameof(CShip))]
    public unsafe partial struct CTransportShip : CTransportShip.Interface
    {
        public void** lpVtbl;

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
        public byte pad_b;

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("WORD")]
        public ushort objectId;

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("BYTE[6]")]
        public fixed byte unk_e[6];

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("enum BaseType")]
        public IEntity.BaseType baseType;

        [NativeInheritance(nameof(IEntity))]
        public byte selectionFlags;

        [NativeInheritance(nameof(IEntity))]
        public byte unk_16;

        [NativeInheritance(nameof(IEntity))]
        public byte unk_17;

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("WORD")]
        public ushort x;

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("WORD")]
        public ushort y;

        [NativeInheritance(nameof(IEntity))]
        public byte unk_1c;

        [NativeInheritance(nameof(IEntity))]
        public byte unk_1d;

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("WORD")]
        public ushort unk_1e;

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("__AnonymousRecord_entities_L110_C17")]
        public IEntity._Anonymous_e__Struct Anonymous;

        [NativeInheritance(nameof(IEntity))]
        public byte health;

        [NativeInheritance(nameof(IEntity))]
        public byte pad_22;

        [NativeInheritance(nameof(IEntity))]
        public byte pad_23;

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
        public byte animationFrameIndex;

        [NativeInheritance(nameof(IAnimatedEntity))]
        public byte unk_25;

        [NativeInheritance(nameof(IAnimatedEntity))]
        [NativeTypeName("WORD")]
        public ushort unk_26;

        [NativeInheritance(nameof(IAnimatedEntity))]
        [NativeTypeName("WORD")]
        public ushort nextEntity;

        [NativeInheritance(nameof(IAnimatedEntity))]
        [NativeTypeName("WORD")]
        public ushort prevEntity;

        [NativeInheritance(nameof(IAnimatedEntity))]
        [NativeTypeName("DWORD")]
        public uint globalTick;

        [NativeInheritance(nameof(IAnimatedEntity))]
        [NativeTypeName("DWORD")]
        public uint unk_30;

        [NativeInheritance(nameof(IAnimatedEntity))]
        public int unk_34;

        [NativeInheritance(nameof(IAnimatedEntity))]
        public int unk_38;

        [NativeInheritance(nameof(IMovingEntity))]
        [NativeTypeName("DWORD")]
        public uint unk_3c;

        [NativeInheritance(nameof(IMovingEntity))]
        [NativeTypeName("CHAR")]
        public sbyte unk_40;

        [NativeInheritance(nameof(IMovingEntity))]
        public byte unk_41;

        [NativeInheritance(nameof(IMovingEntity))]
        public byte unk_42;

        [NativeInheritance(nameof(IMovingEntity))]
        public byte pad_43;

        [NativeInheritance(nameof(IMovingEntity))]
        [NativeTypeName("WORD")]
        public ushort unk_44;

        [NativeInheritance(nameof(IMovingEntity))]
        [NativeTypeName("WORD")]
        public ushort unk_46;

        [NativeInheritance(nameof(IMovingEntity))]
        [NativeTypeName("DWORD")]
        public uint unk_48;

        [NativeInheritance(nameof(IMovingEntity))]
        [NativeTypeName("DWORD")]
        public uint unk_4c;

        [NativeInheritance(nameof(IMovingEntity))]
        [NativeTypeName("LPVOID")]
        public void* unk_50;

        [NativeInheritance(nameof(IMovingEntity))]
        [NativeTypeName("DWORD")]
        public uint unk_54;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("LPVOID")]
        public void* unk_58;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk_5c;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk_5d;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk_5e;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk_5f;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk_60;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk_61;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk_62;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk_63;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk_64;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk_65;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("WORD")]
        public ushort unk_66;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("DWORD")]
        public uint unk_68;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk_6c;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk_6d;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk_6e;

        [NativeInheritance(nameof(CVehicle))]
        public byte unk_6f;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("WORD")]
        public ushort unk_70;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("WORD")]
        public ushort unk_72;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("WORD")]
        public ushort unk_74;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("WORD")]
        public ushort unk_76;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("WORD")]
        public ushort unk_78;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("BYTE[6]")]
        public fixed byte unk_7a[6];

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("INT32")]
        public int unk_80;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("INT32")]
        public int unk_84;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("DWORD")]
        public uint unk_88;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("DWORD")]
        public uint unk_8c;

        [NativeInheritance(nameof(CVehicle))]
        [NativeTypeName("DWORD")]
        public uint unk_90;

        [NativeInheritance(nameof(CShip))]
        [NativeTypeName("DWORD")]
        private uint unk_94;

        [NativeInheritance(nameof(CTransportShip))]
        [NativeTypeName("DWORD[31]")]
        public fixed uint unk_98[31];

        [NativeInheritance(nameof(CTransportShip))]
        public byte unk_114;

        [NativeInheritance(nameof(CTransportShip))]
        [NativeTypeName("BYTE[3]")]
        public fixed byte pad_115[3];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("LPVOID")]
        public void* vfunc0()
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, void*>)(lpVtbl[0]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void serialize([NativeTypeName("DWORD *")] uint* param0)
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, uint*, void>)(lpVtbl[1]))((CTransportShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public IEntity* vfunc2([NativeTypeName("LPVOID")] void* param0)
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, void*, IEntity*>)(lpVtbl[2]))((CTransportShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        public uint clearSelection()
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, uint>)(lpVtbl[3]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void vfunc4()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[4]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("LPVOID")]
        public void* vfunc5()
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, void*>)(lpVtbl[5]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("DWORD")]
        public uint PopulateRenderData(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, int, uint>)(lpVtbl[6]))((CTransportShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void vfunc7([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1)
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, uint, uint, void>)(lpVtbl[7]))((CTransportShip*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void vfunc8([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, uint, void>)(lpVtbl[8]))((CTransportShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void vfunc9()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[9]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc10()
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, uint>)(lpVtbl[10]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc11()
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, uint>)(lpVtbl[11]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void vfunc12()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[12]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void vfunc13(int param0)
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, int, void>)(lpVtbl[13]))((CTransportShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public void vfunc14()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[14]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc15()
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, uint>)(lpVtbl[15]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc16()
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, uint>)(lpVtbl[16]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void vfunc17(int param0, int param1)
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, int, int, void>)(lpVtbl[17]))((CTransportShip*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc18(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, int, uint>)(lpVtbl[18]))((CTransportShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void vfunc19()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[19]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void vfunc20([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, uint, void>)(lpVtbl[20]))((CTransportShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc21()
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, uint>)(lpVtbl[21]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc22()
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, uint>)(lpVtbl[22]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc23()
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, uint>)(lpVtbl[23]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc24()
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, uint>)(lpVtbl[24]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public void vfunc25()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[25]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public void vfunc26()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[26]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public void vfunc27([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, uint, void>)(lpVtbl[27]))((CTransportShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public void vfunc28([NativeTypeName("LPVOID")] void* param0, [NativeTypeName("WORD")] ushort param1)
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void*, ushort, void>)(lpVtbl[28]))((CTransportShip*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public byte vfunc29()
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, byte>)(lpVtbl[29]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public void vfunc30()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[30]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public void vfunc31()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[31]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public void vfunc32()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[32]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public void vfunc33()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[33]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public void vfunc34()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[34]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc35()
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, uint>)(lpVtbl[35]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public void vfunc36()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[36]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public void vfunc37()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[37]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public void vfunc38()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[38]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public void vfunc39(int param0)
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, int, void>)(lpVtbl[39]))((CTransportShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public void vfunc40()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[40]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public void vfunc41([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, uint, void>)(lpVtbl[41]))((CTransportShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public void vfunc42([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, uint, void>)(lpVtbl[42]))((CTransportShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public void vfunc43()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[43]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public void vfunc44()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[44]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public void vfunc45()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[45]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public void vfunc46()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[46]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public void vfunc47()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[47]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public void vfunc48()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[48]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public void vfunc49([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, uint, void>)(lpVtbl[49]))((CTransportShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public void vfunc50([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, uint, void>)(lpVtbl[50]))((CTransportShip*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public byte vfunc51()
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, byte>)(lpVtbl[51]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc52()
        {
            return ((delegate* unmanaged[Thiscall]<CTransportShip*, uint>)(lpVtbl[52]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public void vfunc53()
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, void>)(lpVtbl[53]))((CTransportShip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public void vfunc54([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CTransportShip*, uint, void>)(lpVtbl[54]))((CTransportShip*)Unsafe.AsPointer(ref this), param0);
        }

        public interface Interface : CShip.Interface
        {
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
            public delegate* unmanaged[Thiscall]<TSelf*, int, uint> PopulateRenderData;

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
        }
    }
}
