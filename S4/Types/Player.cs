using Forge.Config;
﻿using AutomaticInterface;
using Forge.S4.Game;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.S4.Types {
    [GenerateAutomaticInterface]
    internal class Player : IPlayer {
        const int PlayerCount = 8;
        private static readonly Player?[] players = new Player?[PlayerCount];
        public static Player FromId(uint id) => players[id] ??= new Player(id);

        public Player() {
            Id = Forge.Native.ModAPI.API.GetLocalPlayer();
        }

        public Player(uint id) => Id = id;

        public uint Id { get; private set; }

        public bool IsLocalPlayer => Id == Forge.Native.ModAPI.API.GetLocalPlayer();

        // TODO: replace with direct memory access
        public int OffensiveFightingStrength => (int)Forge.Native.ModAPI.API.GetOffenceFightingStrength(Id);

        public Tribe Tribe => (Tribe)Forge.Native.ModAPI.API.GetPlayerTribe(Id);


        public bool HasLost => Forge.Native.ModAPI.API.HasPlayerLost(Id) != 0;

    }
}
