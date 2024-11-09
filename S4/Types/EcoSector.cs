using AutomaticInterface;

using Forge.Config;
using Forge.Native;
using Forge.S4.Game;

namespace Forge.S4.Types {

    [GenerateAutomaticInterface]
    internal class EcoSector(uint id) : IEcoSector {
        //TODO: maybe cache eco sector objects

        public uint Id { get; protected set; } = id;

        public IPlayer Owner => DI.Resolve<IPlayerApi>().GetPlayer(0);// TODO: fetch "owner" of EcoSector

        public bool ChangeGoodDistribution(GoodType good, BuildingType building, float percent) {
            //TODO: fetch "owner" of EcoSector to set as player id
            return ModAPI.API.ChangeGoodDistribution((S4_GOOD_ENUM)good, (S4_BUILDING_ENUM)building, (int)(percent * 100), Id, Owner.Id) != 0;
        }

        public bool ChangeGoodPriority(GoodType good, int priority) {
            //TODO: fetch "owner" of EcoSector to set as player id
            return ModAPI.API.ChangeGoodPriority((S4_GOOD_ENUM)good, priority, Id, Owner.Id) != 0;
        }
    }
}
