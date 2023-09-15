using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.Engine {
    public interface IPlugin {
        int Priority { get; }

        void Initialize();
    }
}
