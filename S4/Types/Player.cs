using AutomaticInterface;

using DryIoc;

using Forge.Config;
using Forge.S4.Game;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.S4.Types {

    public partial interface IPlayer { }

    [GenerateAutomaticInterface]
    internal class Player : IPlayer {
        private const int PlayerCount = 8;

        internal static void RegisterPlayers() {
            for (uint i = 0; i < PlayerCount; i++) {
                uint id = i;
                DI.Dependencies.Register<IPlayer, Player>(serviceKey: i, made: Made.Of(() => new Player(id)));
            }
        }

        private Player(uint id) => Id = id;

        public uint Id { get; protected set; }

        public bool IsLocalPlayer => Id == Forge.Native.ModAPI.API.GetLocalPlayer();

        // TODO: replace with direct memory access
        public int OffensiveFightingStrength => (int)Forge.Native.ModAPI.API.GetOffenceFightingStrength(Id);

        public Tribe Tribe => (Tribe)Forge.Native.ModAPI.API.GetPlayerTribe(Id);

        public bool HasLost => Forge.Native.ModAPI.API.HasPlayerLost(Id) != 0;
    }
}
