using AutomaticInterface;

using DryIoc;

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
            if (id >= GetNumberOfPlayers()) {
                throw new ArgumentOutOfRangeException(nameof(id), id, "Player ID out of range");
            }

            return DI.Dependencies.Resolve<IPlayer>(serviceKey: id);
        }

        public IPlayer GetLocalPlayer() {
            return GetPlayer(GetLocalPlayerId());
        }

        public uint GetLocalPlayerId() {
            return ModAPI.API.GetLocalPlayer();
        }
    }
}
