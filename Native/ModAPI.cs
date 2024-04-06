using NetModAPI;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.Native {
    internal static class ModAPI {
        internal static INetS4ModApi API;

        static ModAPI() {
            API = new NetS4ModApi();
        }

    }
}
