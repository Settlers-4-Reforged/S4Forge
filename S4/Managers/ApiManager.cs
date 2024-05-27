using DryIoc;

using Forge.Config;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.S4.Managers {
    internal class ApiManager {
        public static void RegisterDependencies() {
            DI.Dependencies.Register<Game.IEventApi, Game.EventApi>(Reuse.Singleton);
            DI.Dependencies.Register<Game.IGfxEngineApi, Game.GfxEngineApi>(Reuse.Singleton);
            DI.Dependencies.Register<Game.IPlayerApi, Game.PlayerApi>(Reuse.Singleton);
            DI.Dependencies.Register<Game.ISoundApi, Game.SoundApi>(Reuse.Singleton);
        }
    }
}
