using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.S4.Types {
    public class Player {
        public uint Id;

        internal Player(uint id) {
            Id = id;
        }

        // TODO: replace with direct memory access
        public int OffensiveFightingStrength => (int)Forge.Native.ModAPI.API.GetOffenceFightingStrength(Id);
    }
}
