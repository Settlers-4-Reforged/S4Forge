using System;
using System.Runtime.InteropServices;

namespace Forge.S4.Types {
    [Flags]
    public enum S4UIScreen : long {
        Unknown = 0,

        MainMenu = 1L << 0,
        Tutorial = 1L << 1,
        AOBriefing = 1L << 2,
        AOSplash = 1L << 3,
        AOCampaigns = 1L << 4,
        AOCampaignsSettle = 1L << 5,
        AOCampaignBonus = 1L << 6,
        AOCampaignMayan = 1L << 7,
        AOCampaignRoman = 1L << 8,
        AOCampaignTrojan = 1L << 9,
        AOCampaignViking = 1L << 10,
        Briefing = 1L << 11,
        Campaign3X3 = 1L << 12,
        CampaignDark = 1L << 13,
        Credits = 1L << 14,
        VictoryScreen = 1L << 15,
        EcoStatistic = 1L << 16,
        EndStatistic = 1L << 17,
        LoadGame = 1L << 18,
        LoadType = 1L << 19,
        LobbyConnect = 1L << 20,
        LobbyGameSettings = 1L << 21,
        LobbyLoadMP = 1L << 22,
        LobbyMapSettings = 1L << 23,
        LobbyMultiplayerType = 1L << 24,
        LocalType = 1L << 25,
        MD2Briefing = 1L << 26,
        MD2Campaigns = 1L << 27,
        MDBriefing = 1L << 28,
        MDCampaignMayan = 1L << 29,
        MDCampaignRoman = 1L << 30,
        MDCampaigns = 1L << 31,
        MDCampaignsEcoConflict = 1L << 32,
        MDCampaignViking = 1L << 33,
        MDRandomMapParameters = 1L << 34,
        MessageBox = 1L << 35,
        Slideshow = 1L << 36,
        Video = 1L << 37,
        XMD3Briefing = 1L << 38,
        XMD3Campaigns = 1L << 39,
        Ingame = 1L << 40,
    }

    [Flags]
    public enum S4UIMenu : long {
        Unknown = 0,

        ExtrasSave = 1L << 0,
        ExtrasMission = 1L << 1,
        ExtrasChatSettings = 1L << 2,
        ExtrasQuit = 1L << 3,

        SettingsGraphics = 1L << 4,
        SettingsAudio = 1L << 5,
        SettingsGame = 1L << 6,
        SettingsNotifications = 1L << 7,

        BuildingsFoundation = 1L << 8,
        BuildingsMetal = 1L << 9,
        BuildingsFood = 1L << 10,
        BuildingsMisc = 1L << 11,
        BuildingsMilitary = 1L << 12,

        SettlersSummary = 1L << 13,
        SettlersWorkers = 1L << 14,
        SettlersSpecialists = 1L << 15,
        SettlersSearch = 1L << 16,

        GoodsSummary = 1L << 17,
        GoodsDistribution = 1L << 18,
        GoodsPriority = 1L << 19,

        StatisticsWarriors = 1L << 20,
        StatisticsLand = 1L << 21,
        StatisticsGoods = 1L << 22,

        UnitSelectionMilitary = 1L << 23,
        UnitSelectionSpecialists = 1L << 24,
        UnitSelectionVehicles = 1L << 25,
        UnitSelectionFerry = 1L << 26,
        UnitSelectionTradingVehicle = 1L << 27,

        SelectionTowerBuilding = 1L << 28,
        SelectionSimpleBuilding = 1L << 29,
        SelectionTransformingBuilding = 1L << 30,
        SelectionResourceBuilding = 1L << 31,
        SelectionTraderBuilding = 1L << 32,
        SelectionStorageBuilding = 1L << 33,
        SelectionBarracksBuilding = 1L << 34,
        SelectionVehicleBuilding = 1L << 35,

        ConfirmDestroy = 1L << 36,
    };

    [Flags]
    public enum S4UISubmenu {
        Unknown = 0,

        BuildingsMiscDecoSubmenu = 1 << 0,
        UnitSelectionSubSpells = 1 << 1,
        UnitSelectionSubGroupings = 1 << 2,
        SelectionSubTrade = 1 << 3,
        SelectionSubStorage = 1 << 4,
        SelectionSubBuildVehicle = 1 << 5,
        SelectionSubBarracks = 1 << 6,
    }

    public enum UIElementTypes : short {
        Ignored = 4,
        PlayerIcon = 6,
        Map = 9,
        UIPlayer = 19,
        TextBox = 20,
        U4Ignored = 20,
        MissionText = 21,
    }

    public enum UIElementTextStyle : short {
        LargeBlue = 0b0000_0000,
        HeaderCentered = 0b0000_1011,//Above input fields
        NormalCentered = 0b0000_0011,
        NormalLeft = 0b0000_1001,
        BoldCentered = 0b0000_0111,
        RedCentered = 0b0000_0010,
        SmallGold = 0b0000_1100,
        SmallBlue = 0b0000_0100,
        SmallWhite = 0b0000_1000,
    }

    [Flags]
    public enum UIElementEffects : short {
        None = 0,
        Pressed = 1,
        Hover = 2,
        Disabled = 4,
        Hidden = 8,
        TextBoxActive = 64,
        CursorBlinkOn = 128,
    };
}
