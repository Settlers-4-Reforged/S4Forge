using DryIoc;

using Forge.Config;
using Forge.S4.Types;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.S4.Managers {
    internal class ApiManager(
        Game.IEntityApi EntityApi,
        Game.IEventApi EventApi,
        Game.IGfxEngineApi GfxEngineApi,
        Game.IPlayerApi PlayerApi,
        Game.ISoundApi SoundApi) {

        public static void ResolveDependencies() {
            DI.Dependencies.Register<ApiManager>(Reuse.Singleton);
            DI.Resolve<ApiManager>();
        }

        public static void RegisterDependencies() {
            DI.Dependencies.Register<Game.IEntityApi, Game.EntityApi>(Reuse.Singleton);
            DI.Dependencies.Register<Game.IEventApi, Game.EventApi>(Reuse.Singleton);
            DI.Dependencies.Register<Game.IGfxEngineApi, Game.GfxEngineApi>(Reuse.Singleton);
            DI.Dependencies.Register<Game.IPlayerApi, Game.PlayerApi>(Reuse.Singleton);
            DI.Dependencies.Register<Game.ISoundApi, Game.SoundApi>(Reuse.Singleton);

            DI.Dependencies.Register<IWorld, World>();
        }
    }
}
