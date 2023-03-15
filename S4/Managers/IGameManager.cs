using S4UI.S4.Types;
using System.Collections.Generic;

namespace S4UI.S4.Managers {
    public interface IGameManager {
        delegate void ScreenCallback(UIScreen previous, UIScreen next);
        delegate void MenuCallback(List<UIMenu> previous, List<UIMenu> next);
        delegate void EventCallback(EventCallbackParameters param);

        //public Action<UIScreen/*previous*/, UIScreen/*new*/> OnS4ScreenChange { get; set; }
        //public Action<List<UIMenu>/*previous*/, List<UIMenu>/*new*/> OnS4MenuChange { get; set; }

        UIScreen[] GetScreens();
        UIMenu[] GetMenus();

        bool RegisterS4ScreenChangeCallback(ScreenCallback callback);
        bool RegisterS4MenuChangeCallback(MenuCallback callback);
        bool RegisterEventCallback(Event eventId, EventCallback callback);
    }

    public struct EventCallbackParameters {
        public Event EventId;
        public int Timestamp;
        //Maybe:
        public int Caller;
    }
}
