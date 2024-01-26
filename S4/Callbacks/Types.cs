using Forge.S4.Types;

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Forge.S4.Callbacks {

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct S4EntityDrawParams {
        public IntPtr caller;
        public IntPtr /*<word>*/ imagePalette;
        public IntPtr /*<byte>*/ imageData;
        public Int32 imageWidth;
        public Int32 imageHeight;
        public Int32 destX;
        public Int32 destY;
        public Int32 destClippingOffsetY;
        public IntPtr /*<word>*/ subSurface;
        public bool imageHighRes;
        public Int32 destWidth;
        public Int32 destHeight;
        public Int32 surfaceWidth;
        public Int32 surfaceHeight;
        public Int32 stride;
        public Int32 zoomFactor;
        public IntPtr /*<word>*/ surface;
        public bool isFogOfWar;
        public Int16 settlerId;
        public Int16 spriteId;
        public IntPtr /*<HDC>*/ destinationDc;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct S4UIElementDrawParams {
        public Int32 surfaceWidth;
        public Int32 surfaceHeight;
        public Int16 activeGFXCollection;
        public Int16 elementContainerId;
        public Int16 x;
        public Int16 y;
        public Int16 xOffset;
        public Int16 yOffset;
        public Int16 width;
        public Int16 height;
        public Int16 mainTexture;
        public Int16 valueLink;
        public Int16 buttonPressedTexture;
        public Int16 tooltipLink;
        public Int16 tooltipLinkExtra;
        public UIElementTypes elementType;
        public UIElementEffects effects; //When == 8 -> hide text
        //public enum where the first 4 bits define which font style to use and last 4 bits define effects (Like pressed etc)
        public UIElementTextStyle textStyle;
        public Int16 showTexture;
        public Int16 backTexture;
        public IntPtr text;
        public IntPtr tooltipText;
        public IntPtr tooltipExtraText;
    }
}
