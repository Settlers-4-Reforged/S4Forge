using AutomaticInterface;

using Forge.Config;
using Forge.Native;
using Forge.S4.Types;
using Forge.S4.Types.Native;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.S4.Game {

    [GenerateAutomaticInterface]
    internal class EventApi : IEventApi {
        private unsafe void* EventManager => (void*)GameValues.ReadValue<int>(0x106B11C);

        public void SendEvent(EventType type, uint wparam, uint lparam, sbyte unknown) {
            unsafe {
                Event newEvent;
                void* s4event = ModAPI.API.CreateS4Event(&newEvent, (uint)type, wparam, lparam, unknown);
                ModAPI.API.PostToMessageQueue(EventManager, s4event);
            }
        }
    }
}
