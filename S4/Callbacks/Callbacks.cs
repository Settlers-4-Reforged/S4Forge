using Forge.Native;

using Microsoft.DirectX.DirectDraw;

using NetModAPI;

using System;
using System.Collections.Generic;
using System.Text;

using DirectDrawSurface = Microsoft.DirectX.DirectDraw.Surface;

namespace Forge.S4.Callbacks {
    public static class Callbacks {
        /*
        S4FrameCallback(LPDIRECTDRAWSURFACE7 lpSurface, INT32 iPillarboxWidth, LPVOID lpReserved)
        S4MapInitCallback(LPVOID lpReserved0, LPVOID lpReserved1)
        S4MouseCallback(DWORD dwMouseButton, INT iX, INT iY, DWORD dwMsgId, HWND hwnd, LPCS4UIELEMENT lpUiElement)
        S4SettlerSendCallback(DWORD dwPosition, S4_MOVEMENT_ENUM dwCommand, LPVOID lpReserved)
        S4TickCallback(DWORD dwTick, BOOL bHasEvent, BOOL bIsDelayed)
        S4LuaOpenCallback()
        S4BltCallback(LPS4BLTPARAMS params, BOOL discard)
        S4GuiBltCallback(LPS4GUIBLTPARAMS params, BOOL discard)
        S4EntityCallback(WORD entity, S4_ENTITY_CAUSE cause); // called when an entity is spawned or destructed
        S4GuiDrawCallback(LPS4GUIDRAWBLTPARAMS entity, BOOL discard)
        S4GuiClearCallback(LPS4GUICLEARPARAMS entity, BOOL discard)
        */

        public delegate void GameFrameCallback(DirectDrawSurface? surface, int pillarBoxWidth, IntPtr reserved);


        public static event GameFrameCallback? OnFrame;


        static unsafe Callbacks() {
            ModAPI.API.AddFrameListener((IDirectDrawSurface7* surface, Int32 width, void* reserved) => {
                using Surface? directDrawSurface = DDrawUtil.SurfaceFromPointer(surface);

                OnFrame?.Invoke(directDrawSurface, width, new IntPtr(reserved));

                return 0;
            });
        }
    }
}
