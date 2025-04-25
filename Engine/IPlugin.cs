using DryIoc;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.Engine {
    public interface IPlugin {
        /// <summary>
        /// Callback to initialize and activate the plugin.
        /// This is called after RegisterDependencies and should be used to implement any plugin wide logic.
        /// </summary>
        void Activate();


        /// <summary>
        /// Cleanup function for when the plugin either gets deactivate or when forge gets unloaded
        /// </summary>
        void Deactivate();
    }

    /// <summary>
    /// A callback interface for DI registered classes that need to be called after all plugins have been loaded and initialized
    /// </summary>
    public interface IAfterModulesLoaded {
        void AfterModulesLoaded();
    }
}
