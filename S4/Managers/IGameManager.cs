using S4_UIEngine.GameTypes;
using System;
using System.Collections.Generic;

namespace S4_UIEngine.S4.Managers {
    public interface IGameManager {
        public delegate void ScreenCallback(GuiScreen previous, GuiScreen next);
        public delegate void MenuCallback(List<GuiMenu> previous, List<GuiMenu> next);
        public delegate void EventCallback(EventCallbackParameters param);

        public Action<GuiScreen/*previous*/, GuiScreen/*new*/> OnS4ScreenChange { get; set; }
        public Action<List<GuiMenu>/*previous*/, List<GuiMenu>/*new*/> OnS4MenuChange { get; set; }


        public bool RegisterS4ScreenChangeCallback(ScreenCallback callback);
        public bool RegisterS4MenuChangeCallback(MenuCallback callback);
        public bool RegisterEventCallback(EventCallback callback);
    }

    public struct EventCallbackParameters {
        public int EventId;
        public int Timestamp;
        //Maybe:
        public int Caller;
    }
}
