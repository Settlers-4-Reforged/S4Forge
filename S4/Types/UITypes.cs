using System;
using System.Runtime.InteropServices;

namespace Forge.S4.Types {
    public enum UIScreen {
        Unknown = 0,

        MainMenu = 1,
        Tutorial,
        Addon,
        MissionCd,
        NewWorld,
        NewWorld2,
        Singleplayer,
        Multiplayer,
        LoadGame,
        Credits,
        AddonTrojan,
        AddonRoman,
        AddonMayan,
        AddonViking,
        AddonSettle,
        MissionCdRoman,
        MissionCdViking,
        MissionCdMayan,
        MissionCdConfl,
        SingleplayerCampaign,
        SingleplayerDarktribe,
        SingleplayerMapSelectSingle,
        SingleplayerMapSelectMulti,
        SingleplayerMapSelectRandom,
        SingleplayerMapSelectUser,
        SingleplayerLobby,
        MultiplayerMapSelectMulti,
        MultiplayerMapSelectRandom,
        MultiplayerMapSelectUser,
        MultiplayerLobby,
        LoadGameCampaign,
        LoadGameMap,
        LoadGameMultiplayer,
        AfterGameSummary,
        AfterGameDetails,
        Ingame,
        MissionDescription,

        Max
    }

    public enum UIMenu {
        S4GuiUnknown = 0,

        ExtrasSave = UIScreen.Max,
        ExtrasMission,
        ExtrasChatSettings,
        ExtrasQuit,
        SettingsGraphics,
        SettingsAudio,
        SettingsGame,
        SettingsNotifications,
        BuildingsFoundation,
        BuildingsMetal,
        BuildingsFood,
        BuildingsMisc,
        BuildingsMiscDecoSubmenu,
        BuildingsMilitary,
        SettlersSummary,
        SettlersWorkers,
        SettlersSpecialists,
        SettlersSearch,
        GoodsSummary,
        GoodsDistribution,
        GoodsPriority,
        StatisticsWarriors,
        StatisticsLand,
        StatisticsGoods,
        UnitSelectionDonkey,
        UnitSelectionMilitary,
        UnitSelectionSpecialists,
        UnitSelectionVehicles,
        UnitSelectionFerry,
        UnitSelectionTradingVehicle,
        UnitSelectionSubSpells,
        UnitSelectionSubGroupings,
        SelectionSubTrade,
        SelectionSubBuildVehicle,
        SelectionSubBarracks,

        Max // never put anything below this
    };

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
