using DryIoc;

using Forge.Config;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.S4.Managers {
    internal class ApiManager {
        public static void RegisterDependencies() {
            DI.Dependencies.Register<Game.PlayerApi, Game.PlayerApi>();
        }
    }
}
