using Forge.S4.Types;
using Forge.S4.Types.Native.Helpers;

namespace Forge.S4.Types.Native.Config
{
    public unsafe partial struct CConfigVarMapNode
    {
        [NativeInheritance(nameof(CConfigVarMapNode))]
        public CConfigVarMapNode* parent;

        [NativeInheritance(nameof(CConfigVarMapNode))]
        public CConfigVarMapNode* left;

        [NativeInheritance(nameof(CConfigVarMapNode))]
        public CConfigVarMapNode* right;

        [NativeInheritance(nameof(CConfigVarMapNode))]
        [NativeTypeName("char")]
        public sbyte unk_12;

        [NativeInheritance(nameof(CConfigVarMapNode))]
        [NativeTypeName("char")]
        public sbyte isUnpopulatedNode;

        [NativeInheritance(nameof(CConfigVarMapNode))]
        public short unk_14;

        [NativeInheritance(nameof(CConfigVarMapNode))]
        public wstring key;

        [NativeInheritance(nameof(CConfigVarMapNode))]
        public CConfigVar* value;
    }
}
