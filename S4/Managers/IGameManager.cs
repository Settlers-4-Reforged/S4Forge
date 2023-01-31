using S4UIEngine.S4.Types;
using System;
using System.Collections.Generic;

namespace S4UIEngine.S4.Managers {
    public interface IGameManager {
        public delegate void ScreenCallback(UIScreen previous, UIScreen next);
        public delegate void MenuCallback(List<UIMenu> previous, List<UIMenu> next);
        public delegate void EventCallback(EventCallbackParameters param);

        public Action<UIScreen/*previous*/, UIScreen/*new*/> OnS4ScreenChange { get; set; }
        public Action<List<UIMenu>/*previous*/, List<UIMenu>/*new*/> OnS4MenuChange { get; set; }


        public bool RegisterS4ScreenChangeCallback(ScreenCallback callback);
        public bool RegisterS4MenuChangeCallback(MenuCallback callback);
        public bool RegisterEventCallback(Event eventId, EventCallback callback);
    }

    public struct EventCallbackParameters {
        public Event EventId;
        public int Timestamp;
        //Maybe:
        public int Caller;
    }
}
