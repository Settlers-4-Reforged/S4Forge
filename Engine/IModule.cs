using DryIoc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Engine {
    public interface IModule {
        string Name { get; }
        bool Active { get => true; }

        int Priority { get => default; }

        /// <summary>
        /// Initialization method to register plugins.
        /// This should not be used to implement any logic, but rather check for dependencies and register plugins.
        /// </summary>
        /// <remarks>
        /// This method is called in the order of the plugin priority
        /// </remarks>
        void Initialize(Container injector);
    }
}
