using Forge.Config;
using Forge.Native;
using Forge.S4.Types;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.S4.Game {

    [GenerateAutomaticInterface]
    internal sealed class PlayerApi : IPlayerApi {
        public uint GetNumberOfPlayers() {
            return ModAPI.API.GetNumberOfPlayers();
        }

        public IPlayer GetPlayer(uint id) {
            return Player.FromId(id);
        }

        public IPlayer GetLocalPlayer() {
            return GetPlayer(GetLocalPlayerId());
        }

        // TODO: Add mapping to a Player object, that contains more information about the player
        public uint GetLocalPlayerId() {
            return ModAPI.API.GetLocalPlayer();
        }

        public Tribe GetCurrentTribe() {
            uint player = GetLocalPlayerId();

            return (Tribe)ModAPI.API.GetPlayerTribe(player);
        }
    }
}
