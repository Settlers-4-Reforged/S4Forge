using NetModAPI;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.Native {
    public static class ModAPI {
        public static NetS4ModApi API;

        static ModAPI() {
            API = new NetS4ModApi();
        }
    }
}
