using Forge.S4.Types;
using Forge.S4.Types.Native.Helpers;

namespace Forge.S4.Types.Native.Config
{
    public partial struct CConfigSection
    {
        [NativeInheritance(nameof(CConfigSection))]
        public wstring name;

        [NativeInheritance(nameof(CConfigSection))]
        public ConfigVarMap configVarMap;
    }
}
