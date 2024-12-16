using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Engine {
    public class PluginEnvironment<TPlugin> where TPlugin : IPlugin {
        /// <summary>
        /// The path of where the plugin is installed to. Typically under "Forge\Plugins\:plugin-name\"
        /// </summary>
        /// <remarks>
        /// Always ends with a trailing slash
        /// </remarks>
        public string Path { get; init; }

        internal PluginEnvironment(string path) {
            this.Path = path;
        }
    }
}
