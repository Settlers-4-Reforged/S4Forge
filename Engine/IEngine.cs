using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.Engine {
    public interface IEngine {
        string Name { get; }

        bool Initialize(S4Forge forge);
    }
}
