using System;

namespace Forge.S4.Types {
    public enum Team {
        Red = 0,
        Blue,
        Green,
        Yellow,
        Purple,
        Orange,
        Cyan,
        White,
        Max,
    }

    public enum Tribe {
        Roman = 0,
        Viking,
        Maya,
        Dark,
        Trojan,
        Default = -1,
    }

    public enum EntityType : byte {
        Unknown,

        Building,
        Pile,

        // Ground Mobile Entities
        // Settler
        Settler,
        // Animal
        Landanimal,
        // Vehicles
        // Wheelers
        Cart,
        // Catapult
        CatapultMaya,
        CatapultTrojan,
        CatapultRoman,
        CatapultViking,
        // Ships
        Ferry,
        Transportship,
        // War Ship
        WarshipMaya,
        WarshipTrojan,
        WarshipRoman,
        WarshipViking,

        // Flying Mobile Entites
        Manakopter,

        // Stationary Deco Entities
        Deco,
        Hive,
        Mushroom,
        Plant,
        ShadowHerb,
        Stone,
        Tree,
    };

    public enum GroundType : byte {
        Water1 = 0, // water1 does only exist without waves (it ignores the pond flag)
        Water2 = 1, // this ground respects the pond flag
        Water3 = 2, // this ground respects the pond flag
        Water4 = 3, // this ground respects the pond flag
        Water5 = 4, // this ground respects the pond flag
        Water6 = 5, // this ground respects the pond flag
        Water7 = 6, // this ground respects the pond flag
        Water8 = 7, // deep sea, this ground respects the pond flag
        Grass = 16,
        GrassRock = 17, // transition triangles only: grass grass rock
        GrassIsle = 18,
        GrassDesert = 20, // transition triangles only: grass grass desert
        GrassSwamp = 21, // transition triangles only: grass grass swamp
        GrassMud = 23,  // transition triangles only: grass grass mud
        Darkgrass = 24,
        DarkgrassGrass = 25, // transition triangles only: darkgrass darkgrass grass
        Sandyroad = 28,
        Cobbledroad = 29,
        Rock = 32,
        RockGrass = 33, // transition triangles only: rock rock grass
        RockSnow = 35, // transition triangles only: rock rock snow
        Beach = 48,
        Desert = 64,
        DesertGrass = 65, // transition triangles only: desert desert grass
        Swamp = 80,
        SwampGrass = 81, // transition triangles only: swamp swamp grass
        River1 = 96,
        River2 = 97,
        River3 = 98,
        River4 = 99,
        Snow = 128,
        SnowRock = 129,  // transition triangles only: snow snow rock
        Mud = 144,
        MudGrass = 145,  // transition triangles only: mud mud grass
    };

    public enum ResourceType : byte {
        None,
        Fish,
        Coal = Fish + 16,
        Iron = Coal + 16,
        Gold = Iron + 16,
        Sulfur = Gold + 16,
        DeepStone = Sulfur + 16,
        Stone = DeepStone + 16,
        Tree = Stone + 16,
    };

    // Roles define what an entity "does" or is destined for. You may create custom 
    // roles for entities. Just make sure to implement the proper Role interface for 
    // the entity type (building/pile/settler) you wish to program.
    public enum EntityRole : byte {
        Unknown,

        // Pile Roles
        PileAnywhere,
        PileBuildingSite,
        PileDelivery,
        PileProduction,
        PileStorage,
        PileTrade,

        // Building Roles
        BuildingWorkup,  // needs confirmation
        BuildingAnimalranch,
        BuildingMilitary, // needs confirmation
        BuildingCastle,
        BuildingTrading,
        BuildingBarrack,
        BuildingBigtemple,
        BuildingSite,
        BuildingMushroomfarm,
        BuildingDarktemple,
        BuildingEyecatcher,
        BuildingFarm,
        BuildingGather,
        BuildingLookouttower,
        BuildingManakopterhall,
        BuildingMine,
        BuildingProduction,
        BuildingResidence,
        BuildingSimple,
        BuildingSmalltemple,
        BuildingStorage,
        BuildingWorkshop,

        // Settler Roles
        SettlerBuilder,
        SettlerCarrier,
        SettlerDarkgardener,
        SettlerDigger,
        SettlerDonkey,
        SettlerDoor,
        SettlerFlee,
        SettlerFreeworker,
        SettlerHouseworker,
        SettlerHunter,
        SettlerMushroomfarmer,
        SettlerSlave,
        SettlerTowersoldier,

        // The following are selectables
        SettlerGardener,
        SettlerGeologist,
        SettlerPioneer,
        SettlerPriest,
        SettlerThief,

        // The following roles have a WarriorBehaviour attached. Note that 
        // war machines/ships do not have a role but inherit directly from WarriorBehaviour!
        SettlerSoldier,
        SettlerSquadleader,  // needs confirmation
        SettlerHjb,  // needs confirmation
        SettlerShaman,
        SettlerSaboteur,
    };

    public enum GoodType : byte {
        None = 0,
        Agave, // good id 1
        Ammo,
        Armor,
        Axe,
        Battleaxe,
        Blowgun,
        Board,
        Bow,
        Bread,
        Coal, // 10
        Fish,
        Flour,
        Goat,
        Goldbar,
        Goldore,
        Grain,
        Gunpowder,
        Hammer,
        Honey,
        Ironbar,// 20
        Ironore,
        Log,
        Mead,
        Meat,
        Pickaxe,
        Pig,
        Rod,
        Saw,
        Scythe,
        Sheep, // 30
        Shovel,
        Stone,
        Sulfur,
        Sword,
        Tequila,
        Water,
        Wine,
        Backpackcatapult,
        Goose,
        Explosivearrow, // 40
        Sunfloweroil,
        Sunflower, // good id 42
    };

    public enum BuildingType : byte {
        None = 0,
        //S4_BUILDING_READY,
        //S4_BUILDING_UNDERCONSTRUCTION,
        Woodcutterhut, // building id 1
        Foresterhut,
        Sawmill,
        Stonecutterhut,
        Waterworkhut,
        Fisherhut,
        Hunterhut,
        Slaughterhouse,
        Mill,
        Bakery, // 10
        Grainfarm,
        Animalranch,
        Donkeyranch,
        Stonemine,
        Ironmine,
        Goldmine,
        Coalmine,
        Sulfurmine,
        Smeltgold,
        Smeltiron, // 20
        Toolsmith,
        Weaponsmith,
        Vehiclehall,
        Barracks,
        Charcoalmaker,
        Trainingcenter,
        Healerhut,
        Ammomakerhut,
        Gunpowdermakerhut,
        Landscapemakerhut, // 30
        Shipyard,
        Port,
        Marketplace,
        Storagearea,
        Vinyard,
        Agavefarmerhut,
        Tequilamakerhut,
        Beekeeperhut,
        Meadmakerhut,
        Residencesmall,// 40
        Residencemedium,
        Residencebig,
        Smalltemple,
        Bigtemple,
        Lookouttower,
        Guardtowersmall,
        Guardtowerbig,
        Castle,
        Mushroomfarm,
        Darktemple, // 50
        Fortress,
        Porta,
        Portb,
        Portc,
        Portd,
        Porte,
        Portf,
        Shipyarda,
        Shipyardb,
        Shipyardc,
        Shipyardd,
        Shipyarde,
        Shipyardf,
        Eyecatcher01,
        Eyecatcher02,
        Eyecatcher03,
        Eyecatcher04,
        Eyecatcher05,
        Eyecatcher06,
        Eyecatcher07,
        Eyecatcher08,
        Eyecatcher09,
        Eyecatcher10,
        Eyecatcher11,
        Eyecatcher12,
        Shipyardg,
        Shipyardh,
        Portg,
        Porth,
        Manacopterhall,
        Sunfloweroilmakerhut,
        Sunflowerfarmerhut,
    };

    public enum SettlerType : byte {
        None = 0,
        Carrier, // settler id 1
        Digger,
        Builder,
        Woodcutter,
        Stonecutter,
        Forester,
        Farmergrain,
        Farmeranimals,
        Fisher,
        Waterworker,
        Hunter,
        Sawmillworker,
        Smelter,
        Mineworker,
        Smith,
        Miller,
        Baker,
        Butcher,
        Shipyardworker,
        Healer,
        Charcoalmaker,
        Ammomaker,
        Vehiclemaker,
        Vintner,
        Beekeeper,
        Meadmaker,
        Agavefarmer,
        Tequilamaker,
        Swordsman01,
        DarkWarrior = Swordsman01,
        Swordsman02,
        Swordsman03,
        Bowman01,
        DarkThrower = Bowman01,
        Bowman02,
        Bowman03,
        Medic01,
        Medic02,
        Medic03,
        Axewarrior01,
        Axewarrior02,
        Axewarrior03,
        Blowgunwarrior01,
        Blowgunwarrior02,
        Blowgunwarrior03,
        Squadleader,
        Priest,
        Saboteur,
        Pioneer,
        Thief,
        Geologist,
        Gardener,
        Landscaper,
        Darkgardener,
        Mushroomfarmer,
        Shaman,
        SlavedSettler,
        TempleServant,
        Angel01,
        Angel02,
        Angel03,
        Donkey,
        Backpackcatapultist01,
        Backpackcatapultist02,
        Backpackcatapultist03,
        Sunflowerfarmer,
        Sunfloweroilmaker,
        Manacoptermaster,

        Unk68 = 68, // The first 6 entities of a game are this. Maybe the spawn flags set in the editor?
        Unk69 = 69, // Probably door swordman of a tower
    };

    public enum AnimalType : byte {
        None = 0,
        Hog = 1,
        Bug1 = 2, // unconfirmed, is it an IEntity?
        Bug2 = 3, // unconfirmed, is it an IEntity?
        DeerFemale = 4,
        DeerMale = 5,
        Fox = 6,
        Chicken = 7, // unconfirmed, is it an IEntity?
        Jaguar = 8, // unconfirmed
        BunnyRed = 9,
        Dolphin = 10, // unconfirmed, probably not an IEntity
        SeaMonster = 11, // unconfirmed, probably not an IEntity
        Shark = 12, // unconfirmed, probably not an IEntity
        Bear = 13, // unconfirmed
        Wolf = 14, // unconfirmed
        Fish = 15, // unconfirmed, probably not an IEntity
        BunnyGray = 16,
        Bull = 17, // unconfirmed
        Seagul = 0, // unknown, probably an effect?
        Donkey = 0, // unknown, probably an ISettler?
        Butterfly1 = 0, // unknown, probably an effect?
        Butterfly2 = 0, // unknown, probably an effect?
        Butterfly3 = 0, // unknown, probably an effect?
        DuckMale = 0,  // unknown, probably an effect?
        DuckFemale = 0,  // unknown, probably an effect?
        Parrot = 0,  // unknown, probably an effect?
    };

    public enum VehicleType : byte {
        None = 0,
        Warship, // vehicle id 1
        Ferry,
        Transportship,
        Warmachine,
        Cart,
        FoundationCart,
    };

    public enum TreeType : byte {
        None = 0,
        Oak = 1,
        Beech = 2,
        Ash = 3,
        Linden = 4,
        Birch = 5,
        Poplar = 6,
        Chestnut = 7,
        Maple = 8,
        Fir = 9,
        Spruce = 10,
        Coconut = 11,
        Date = 12,
        Walnut = 13,
        Corkoak = 14,
        Pine = 15,
        Pine2 = 16,
        OliveLarge = 17,
        OliveSmall = 18,

        // Trees the tribes grow
        Roman1 = Fir,
        Roman2 = Spruce,
        Viking1 = Fir,
        Viking2 = Spruce,
        Maya1 = Walnut,
        Maya2 = Corkoak,
        Trojan1 = Pine,
        Trojan2 = Pine2,
        Trojan3 = OliveLarge,
        Trojan4 = OliveSmall,
    };

    enum SoundType : uint {
        None = 0,
    };

    enum SpellType : byte {
        SpellNone = 0,
        Spell1,
        Spell2,
        Spell3,
        Spell4,
        Spell5,
        Spell6,
        Spell7,
        Spell8,
    };

}
