using Forge.S4.Types;
using Forge.S4.Types.Native.Helpers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Forge.S4.Types.Native.Entities
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [NativeTypeName("struct CAnimal : IMovingEntity")]
    [NativeInheritance(nameof(IMovingEntity))]
    public unsafe partial struct CAnimal : CAnimal.Interface
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
        public byte unk_e;

        [NativeInheritance(nameof(IEntity))]
        public byte unk_f;

        [NativeInheritance(nameof(IEntity))]
        [NativeTypeName("DWORD")]
        public uint unk_10;

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
        [NativeTypeName("__AnonymousRecord_entities_L112_C17")]
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

        [NativeInheritance(nameof(CAnimal))]
        [NativeTypeName("WORD")]
        public ushort unk_58;

        [NativeInheritance(nameof(CAnimal))]
        [NativeTypeName("BYTE[14]")]
        public fixed byte unk_5a[14];

        [NativeInheritance(nameof(CAnimal))]
        public byte unk_68;

        [NativeInheritance(nameof(CAnimal))]
        public byte unk_69;

        [NativeInheritance(nameof(CAnimal))]
        public byte unk_6a;

        [NativeInheritance(nameof(CAnimal))]
        public byte unk_6b;

        [NativeInheritance(nameof(CAnimal))]
        public byte unk_6c;

        [NativeInheritance(nameof(CAnimal))]
        public byte unk_6d;

        [NativeInheritance(nameof(CAnimal))]
        [NativeTypeName("WORD")]
        public ushort pad_6e;

        [NativeInheritance(nameof(CAnimal))]
        [NativeTypeName("DWORD")]
        public uint unk_70;

        [NativeInheritance(nameof(CAnimal))]
        [NativeTypeName("DWORD")]
        public uint unk_74;

        [NativeInheritance(nameof(CAnimal))]
        [NativeTypeName("DWORD")]
        public uint unk_78;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("LPVOID")]
        public void* vfunc0()
        {
            return ((delegate* unmanaged[Thiscall]<CAnimal*, void*>)(lpVtbl[0]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void serialize([NativeTypeName("DWORD *")] uint* param0)
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, uint*, void>)(lpVtbl[1]))((CAnimal*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public IEntity* vfunc2([NativeTypeName("LPVOID")] void* param0)
        {
            return ((delegate* unmanaged[Thiscall]<CAnimal*, void*, IEntity*>)(lpVtbl[2]))((CAnimal*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc3()
        {
            return ((delegate* unmanaged[Thiscall]<CAnimal*, uint>)(lpVtbl[3]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void vfunc4()
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, void>)(lpVtbl[4]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("LPVOID")]
        public void* PopulateRenderData()
        {
            return ((delegate* unmanaged[Thiscall]<CAnimal*, void*>)(lpVtbl[5]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("DWORD")]
        public uint Heal([NativeTypeName("DWORD")] uint health)
        {
            return ((delegate* unmanaged[Thiscall]<CAnimal*, uint, uint>)(lpVtbl[6]))((CAnimal*)Unsafe.AsPointer(ref this), health);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void DamageBy([NativeTypeName("DWORD")] uint damage, [NativeTypeName("DWORD")] uint attackingEntityId)
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, uint, uint, void>)(lpVtbl[7]))((CAnimal*)Unsafe.AsPointer(ref this), damage, attackingEntityId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void Damage([NativeTypeName("DWORD")] uint damage)
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, uint, void>)(lpVtbl[8]))((CAnimal*)Unsafe.AsPointer(ref this), damage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void vfunc9()
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, void>)(lpVtbl[9]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("DWORD")]
        public uint GetHealth()
        {
            return ((delegate* unmanaged[Thiscall]<CAnimal*, uint>)(lpVtbl[10]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc11()
        {
            return ((delegate* unmanaged[Thiscall]<CAnimal*, uint>)(lpVtbl[11]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void vfunc12()
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, void>)(lpVtbl[12]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void vfunc13(int param0)
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, int, void>)(lpVtbl[13]))((CAnimal*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public void vfunc14()
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, void>)(lpVtbl[14]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc15()
        {
            return ((delegate* unmanaged[Thiscall]<CAnimal*, uint>)(lpVtbl[15]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc16()
        {
            return ((delegate* unmanaged[Thiscall]<CAnimal*, uint>)(lpVtbl[16]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void vfunc17(int param0, int param1)
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, int, int, void>)(lpVtbl[17]))((CAnimal*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc18(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<CAnimal*, int, uint>)(lpVtbl[18]))((CAnimal*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void vfunc19()
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, void>)(lpVtbl[19]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void vfunc20([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, uint, void>)(lpVtbl[20]))((CAnimal*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc21()
        {
            return ((delegate* unmanaged[Thiscall]<CAnimal*, uint>)(lpVtbl[21]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc22()
        {
            return ((delegate* unmanaged[Thiscall]<CAnimal*, uint>)(lpVtbl[22]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc23()
        {
            return ((delegate* unmanaged[Thiscall]<CAnimal*, uint>)(lpVtbl[23]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc24()
        {
            return ((delegate* unmanaged[Thiscall]<CAnimal*, uint>)(lpVtbl[24]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public void vfunc25()
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, void>)(lpVtbl[25]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public void vfunc26()
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, void>)(lpVtbl[26]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public void vfunc27([NativeTypeName("DWORD")] uint param0)
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, uint, void>)(lpVtbl[27]))((CAnimal*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public void vfunc28([NativeTypeName("LPVOID")] void* param0, [NativeTypeName("WORD")] ushort param1)
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, void*, ushort, void>)(lpVtbl[28]))((CAnimal*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public byte vfunc29()
        {
            return ((delegate* unmanaged[Thiscall]<CAnimal*, byte>)(lpVtbl[29]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public void vfunc30()
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, void>)(lpVtbl[30]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("DWORD")]
        public uint vfunc31()
        {
            return ((delegate* unmanaged[Thiscall]<CAnimal*, uint>)(lpVtbl[31]))((CAnimal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public void vfunc32([NativeTypeName("CHAR")] sbyte param0)
        {
            ((delegate* unmanaged[Thiscall]<CAnimal*, sbyte, void>)(lpVtbl[32]))((CAnimal*)Unsafe.AsPointer(ref this), param0);
        }

        public interface Interface : IMovingEntity.Interface
        {
            [VtblIndex(30)]
            void vfunc30();

            [VtblIndex(31)]
            [return: NativeTypeName("DWORD")]
            uint vfunc31();

            [VtblIndex(32)]
            void vfunc32([NativeTypeName("CHAR")] sbyte param0);
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
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc3;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc4;

            [NativeTypeName("LPVOID () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void*> PopulateRenderData;

            [NativeTypeName("DWORD (DWORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint, uint> Heal;

            [NativeTypeName("void (DWORD, DWORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint, uint, void> DamageBy;

            [NativeTypeName("void (DWORD) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint, void> Damage;

            [NativeTypeName("void () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, void> vfunc9;

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> GetHealth;

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

            [NativeTypeName("DWORD () __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint> vfunc31;

            [NativeTypeName("void (CHAR) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte, void> vfunc32;
        }
    }
}
