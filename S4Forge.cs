using Forge.Engine;

using NetModAPI;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge {
    public class S4Forge : IPlugin {
        public void Initialize() {
            IEnumerable<IEngine> engines = ModuleLoader.CreateAvailableEngines();

            foreach (IEngine engine in engines) {
                Logger.LogInfo($"Initializing \"{engine.Name}\"...");
                engine.Initialize(this);
                Logger.LogInfo($"Finished initializing \"{engine.Name}\"...");
            }
        }
    }
}
