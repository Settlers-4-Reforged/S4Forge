using Forge.S4.Types;
using Forge.S4.Types.Native.Helpers;

namespace Forge.S4.Types.Native.Config
{
    public unsafe partial struct ConfigSectionList
    {
        [NativeInheritance(nameof(ConfigSectionList))]
        public CConfigSectionListNode* start;

        [NativeInheritance(nameof(ConfigSectionList))]
        public int length;
    }
}
