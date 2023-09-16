using System;
using System.Runtime.InteropServices;

namespace Forge.S4.Types {

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct S4UIElement {
        public Int16 x;                     //0
        public Int16 y;                     //2
        public Int16 width;                 //4
        public Int16 height;                //6
        public Int16 mainTexture;           //8
        public Int16 valueLink;             //10
        public Int16 unknown;               //12
        public Int16 buttonPressedTexture;  //14
        public Int32 textOffset;            //16
        public Int16 tooltipLink;           //20
        public Int16 tooltipLinkExtra;      //22
        public Byte imageStyle;             //24
        public Byte id;                     //25
        //enum where the first 4 bits define which font style to use and last 4 bits define effects (Like pressed etc)
        public Byte textStyle;              //26
        public Byte effects;                //27
        public Int16 unknown4;              //28
        public Byte drawParams;             //30
        public Byte uiGroupId;            //31
        public Byte unknownData0;           //32
        public Byte caretPosition;          //33
        public Int16 unknownData1;          //34
        //sizeof == 38
    };
}
