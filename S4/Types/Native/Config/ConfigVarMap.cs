using Forge.S4.Types;
using Forge.S4.Types.Native.Helpers;

namespace Forge.S4.Types.Native.Config
{
    public unsafe partial struct ConfigVarMap
    {
        [NativeInheritance(nameof(ConfigVarMap))]
        public CConfigVarMapNode* root;

        [NativeInheritance(nameof(ConfigVarMap))]
        public int size;
    }
}
