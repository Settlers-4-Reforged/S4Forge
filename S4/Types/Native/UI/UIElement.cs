using System;
using System.Runtime.InteropServices;

namespace Forge.S4.Types.Native.UI {

    /// <summary>
    /// Represents a UI Element in the game
    /// </summary>
    /// <remarks>
    /// Avoid to use this type directly, rather use the UX-Engine to interact with the UI
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct S4UIElement {
        public short x;                     //0
        public short y;                     //2
        public short width;                 //4
        public short height;                //6
        public short mainTexture;           //8
        public short valueLink;             //10
        public short unknown;               //12
        public short buttonPressedTexture;  //14
        public int textOffset;            //16
        public short tooltipLink;           //20
        public short tooltipLinkExtra;      //22
        public byte imageStyle;             //24
        public byte id;                     //25
        //enum where the first 4 bits define which font style to use and last 4 bits define effects (Like pressed etc)
        public byte textStyle;              //26
        public byte effects;                //27
        public short unknown4;              //28
        public byte drawParams;             //30
        public byte uiGroupId;            //31
        public byte unknownData0;           //32
        public byte caretPosition;          //33
        public short unknownData1;          //34
        //sizeof == 38
    };
}
