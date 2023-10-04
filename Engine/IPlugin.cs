using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.Engine {
    public interface IPlugin {
        int Priority { get; }
        string Version { get; }
        string[] DependencyFolders { get; }


        void Initialize();
    }
}
