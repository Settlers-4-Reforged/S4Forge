using DryIoc;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.Engine {
    public interface IPlugin {
        int Priority { get; }

        /// <summary>
        /// Callback to register any further DI dependencies. This is called before Initialize and should not be used to implement any logic.
        /// </summary>
        /// <remarks>
        /// This method is called in the order of the plugin priority
        /// </remarks>
        void RegisterDependencies(Container injector) { }

        /// <summary>
        /// Callback to initialize the plugin. This is called after RegisterDependencies and should be used to implement any plugin wide logic.
        /// </summary>
        /// <remarks>
        /// This method is called in the order of the plugin priority
        /// </remarks>
        void Initialize();
    }

    /// <summary>
    /// A callback interface for DI registered classes that need to be called after all plugins have been loaded and initialized
    /// </summary>
    public interface IAfterPluginsLoaded {
        void AfterPluginsLoaded();
    }
}
