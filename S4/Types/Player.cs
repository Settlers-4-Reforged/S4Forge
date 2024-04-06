using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.S4.Types {
    public class Player {
        const int PlayerCount = 8;
        private static readonly Player?[] players = new Player[PlayerCount];
        public static Player FromId(uint id) => players[id] ??= new Player(id);

        private Player() { }
        private Player(uint id) => Id = id;

        public uint Id { get; init; }

        // TODO: replace with direct memory access
        public int OffensiveFightingStrength => (int)Forge.Native.ModAPI.API.GetOffenceFightingStrength(Id);

        public Tribe Tribe => (Tribe)Forge.Native.ModAPI.API.GetPlayerTribe(Id);


        public bool HasLost => Forge.Native.ModAPI.API.HasPlayerLost(Id) != 0;

    }
}
