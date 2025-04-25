using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Engine {
    public class ModuleEnvironment<TModule> where TModule : IModule {
        /// <summary>
        /// The path of where the plugin is installed to. Typically under "Forge\Plugins\:plugin-name\"
        /// </summary>
        /// <remarks>
        /// Always ends with a trailing slash
        /// </remarks>
        public string Path { get; init; }

        internal ModuleEnvironment(string path) {
            this.Path = path;
        }
    }
}
