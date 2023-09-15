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


    [StructLayout(LayoutKind.Sequential)]
    public struct S4BltParams {
        public IntPtr caller;
        public IntPtr imagePalette;
        public IntPtr imageData;
        public int imageWidth;
        public int imageHeight;
        public int destX;
        public int destY;
        public int destClippingOffsetY;
        public IntPtr subSurface;
        public bool imageHighRes;
        public int destWidth;
        public int destHeight;
        public int surfaceWidth;
        public int surfaceHeight;
        public int stride;
        public uint zoomFactor;
        public IntPtr surface;
        public bool isFogOfWar;
        public ushort settlerId;
        public ushort spriteId;
        public IntPtr destinationDc;
    }

}
