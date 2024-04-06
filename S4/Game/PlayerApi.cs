using Forge.Native;
using Forge.S4.Types;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.S4.Game {

    public interface IPlayerApi {
        uint GetNumberOfPlayers();
        Player GetPlayer(uint id);
        Player GetLocalPlayer();
        uint GetLocalPlayerId();
        Tribe GetCurrentTribe();
    }

    internal class PlayerApi : IPlayerApi {
        public uint GetNumberOfPlayers() {
            return ModAPI.API.GetNumberOfPlayers();
        }

        public Player GetPlayer(uint id) {
            return new Player(id);
        }

        public Player GetLocalPlayer() {
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
