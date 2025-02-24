using Forge.S4.Types;
using Forge.S4.Types.Native.Helpers;

namespace Forge.S4.Types.Native.Config
{
    public unsafe partial struct CConfigSectionListNode
    {
        [NativeInheritance(nameof(CConfigSectionListNode))]
        public CConfigSectionListNode* next;

        [NativeInheritance(nameof(CConfigSectionListNode))]
        public CConfigSectionListNode* prev;

        [NativeInheritance(nameof(CConfigSectionListNode))]
        public CConfigSection* data;
    }
}
