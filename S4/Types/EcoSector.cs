using Forge.Config;
﻿using AutomaticInterface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.S4.Types {

    [GenerateAutomaticInterface]
    internal class EcoSector(uint id) : IEcoSector {
        //TODO: maybe cache eco sector objects

        public uint Id { get; private set; } = id;

        public IPlayer Owner => Player.FromId(0);// TODO: fetch "owner" of EcoSector

        public bool ChangeGoodDistribution(GoodType good, BuildingType building, float percent) {
            //TODO: fetch "owner" of EcoSector to set as player id
            return Forge.Native.ModAPI.API.ChangeGoodDistribution((S4_GOOD_ENUM)good, (S4_BUILDING_ENUM)building, (int)(percent * 100), this.Id, Owner.Id) != 0;
        }

        public bool ChangeGoodPriority(GoodType good, int priority) {
            //TODO: fetch "owner" of EcoSector to set as player id
            return Forge.Native.ModAPI.API.ChangeGoodPriority((S4_GOOD_ENUM)good, priority, this.Id, Owner.Id) != 0;
        }
    }
}
