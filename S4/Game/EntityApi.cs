using AutomaticInterface;

using DryIoc.ImTools;

using Forge.Config;
using Forge.Logging;
using Forge.Native;
using Forge.S4.Callbacks;
using Forge.S4.Types;
using Forge.S4.Types.Native.Entities;

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Numerics;

using static Forge.S4.Game.EntityApi;

namespace Forge.S4.Game {
    public unsafe partial interface IEntityApi {
        /// <inheritdoc />
        global::Forge.S4.Types.EntityClass ClassOf(global::Forge.S4.Types.Native.Entities.IEntity* entity);

        /// <inheritdoc />
        nint GetBackingEntity(uint id);

        /// <inheritdoc />
        global::Forge.S4.Types.Native.Entities.IEntity* GetEntity(uint id);

        /// <inheritdoc />
        global::Forge.S4.Types.Native.Entities.IEntity* GetEntity(int x, int y);

        public unsafe IEntity** BackingEntityPool { get; }
        public uint EntityPoolSize { get; }
        public unsafe ushort** BackingEntityMap { get; }
        public unsafe Selection_t* Selection { get; }
    }

    public unsafe struct Selection_t {
        public ushort* entityIds;
        public ushort* end;

        public uint Count {
            get {
                if (entityIds == null || end == null)
                    return 0;

                return (uint)(end - entityIds);
            }
        }
    }

    //[GenerateAutomaticInterface]
    internal sealed class EntityApi : IEntityApi {
        private readonly IWorld world;

        public unsafe IEntity** BackingEntityPool => (IEntity**)GameValues.GetPointer<IEntity>(0xE9BC38);
        public uint EntityPoolSize => GameValues.ReadValue<uint>(0xE9B0BC, @default: 0);
        public unsafe ushort** BackingEntityMap => (ushort**)GameValues.ReadValue<int>(0x106B0FC);


        public unsafe Selection_t* Selection => GameValues.GetPointer<Selection_t>(0x10865A4);

        public EntityApi(ICallbacks callbacks, IWorld world) {
            this.world = world;
        }

        public unsafe EntityClass ClassOf(IEntity* entity) {
            if (entity == null) return EntityClass.Unknown;

            nint vtable = *(nint*)entity;
            return (vtable - GameValues.S4_Main) switch {
                // todo: the following offsets work only for version with md5 c13883cbd796c614365ab2d670ead561
                0xc5821c => EntityClass.Landanimal,
                0xc585e4 => EntityClass.Building,
                0xc59710 => EntityClass.Cart,
                0xc59814 => EntityClass.CatapultMaya,
                0xc59918 => EntityClass.CatapultTrojan,
                0xc59a1c => EntityClass.CatapultRoman,
                0xc59b20 => EntityClass.CatapultViking,
                0xc59d10 => EntityClass.Deco,
                0xc59e4c => EntityClass.Hive,
                0xc59ec8 => EntityClass.Mushroom,
                0xc59f44 => EntityClass.Plant,
                0xc59fc0 => EntityClass.ShadowHerb,
                0xc5a3b8 => EntityClass.Manakopter,
                0xc5a7bc => EntityClass.Pile,
                0xc5bf20 => EntityClass.Settler,
                0xc5c60c => EntityClass.Ferry,
                0xc5c81c => EntityClass.Transportship,
                0xc5c8fc => EntityClass.WarshipTrojan,
                0xc5ca10 => EntityClass.WarshipViking,
                0xc5cb0c => EntityClass.WarshipMaya,
                0xc5cc20 => EntityClass.WarshipRoman,
                0xc5cde8 => EntityClass.Stone,
                0xc5ce68 => EntityClass.Tree,
                _ => EntityClass.Unknown
            };
        }

        public IntPtr GetBackingEntity(uint id) {
            if (id >= EntityPoolSize) {
                Logger.LogWarn($"Entity ID {id} out of range");
                return IntPtr.Zero;
            }

            unsafe {
                return new IntPtr(BackingEntityPool[id]);
            }
        }

        public unsafe IEntity* GetEntity(uint id) {
            if (id >= EntityPoolSize) {
                Logger.LogWarn($"Entity ID {id} out of range");
                return null;
            }

            return BackingEntityPool[(int)id];
        }

        public unsafe IEntity* GetEntity(int x, int y) {
            unsafe {
                ushort* entityId = BackingEntityMap[y * world.Size + x];

                return entityId == null ? null : GetEntity(*entityId);
            }
        }

    }
}
