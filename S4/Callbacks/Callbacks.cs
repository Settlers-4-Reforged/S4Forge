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

        public delegate void GameFrameCallback(DirectDrawSurface? surface, int pillarBoxWidth);
        public delegate void MapInitCallback();
        public delegate void MouseCallback(uint mouseButton, int x, int y, uint msgId, IntPtr hwnd, IntPtr uiElement);
        public delegate void SettlerSendCallback(uint position, uint command, IntPtr reserved);
        public delegate void TickCallback(uint tick, bool hasEvent, bool isDelayed);
        public delegate void LuaOpenCallback();
        public delegate void BltCallback(IntPtr bltParams, bool discard);
        public delegate void GuiBltCallback(IntPtr bltParams, bool discard);
        public delegate void EntityCallback(ushort entity, ushort cause);
        public delegate void GuiDrawCallback(IntPtr bltParams, bool discard);
        public delegate void GuiClearCallback(IntPtr bltParams, bool discard);


        /// <summary>
        /// Event that is called every frame.
        /// </summary>
        public static event GameFrameCallback? OnFrame;

        /// <summary>
        /// Event that is called when the map is initialized.
        /// </summary>
        public static event MapInitCallback? OnMapInit;

        /// <summary>
        /// Event that is called when the mouse is clicked.
        /// </summary>
        public static event MouseCallback? OnMouse;

        /// <summary>
        /// Event that is called when a settler move command is sent.
        /// </summary>
        public static event SettlerSendCallback? OnSettlerSend;

        /// <summary>
        /// Event that is called every tick.
        /// </summary>
        public static event TickCallback? OnTick;

        /// <summary>
        /// Event that is called when a map script is opened.
        /// </summary>
        public static event LuaOpenCallback? OnLuaOpen;

        /// <summary>
        /// Event that is called when a blt is called.
        /// </summary>
        public static event BltCallback? OnBlt;

        /// <summary>
        /// Event that is called when a gui surface is drawn onto the screen.
        /// </summary>
        public static event GuiBltCallback? OnGuiBlt;

        /// <summary>
        /// Event that is called when an entity is spawned or destructed.
        /// </summary>
        public static event EntityCallback? OnEntity;

        /// <summary>
        /// Event that is called when a gui element is drawn onto a gui surface.
        /// </summary>
        public static event GuiDrawCallback? OnGuiDraw;

        /// <summary>
        /// Event that is called when a gui surface is cleared.
        /// </summary>
        public static event GuiClearCallback? OnGuiClear;



        static unsafe Callbacks() {
            ModAPI.API.AddFrameListener((IDirectDrawSurface7* surface, Int32 width, void* reserved) => {
                using Surface? directDrawSurface = DDrawUtil.SurfaceFromPointer(surface);

                OnFrame?.Invoke(directDrawSurface, width);
                //once reserved is no longer unused, add new version of OnFrame

                return 0;
            });

            ModAPI.API.AddMapInitListener((void* reserved0, void* reserved1) => {
                OnMapInit?.Invoke();
                //once reserved0 or reserved1 is no longer unused, add new version of OnMapInit

                return 0;
            });

            ModAPI.API.AddMouseListener((uint mouseButton, int x, int y, uint msgId, HWND__* hwnd, S4UiElement* uiElement) => {
                OnMouse?.Invoke(mouseButton, x, y, msgId, new IntPtr(hwnd), new IntPtr(uiElement));

                return 0;
            });

            ModAPI.API.AddSettlerSendListener((uint position, S4_MOVEMENT_ENUM command, void* reserved) => {
                OnSettlerSend?.Invoke(position, (uint)command, new IntPtr(reserved));

                return 0;
            });

            ModAPI.API.AddTickListener((uint tick, int hasEvent, int isDelayed) => {
                OnTick?.Invoke(tick, hasEvent != 0, isDelayed != 0);

                return 0;
            });

            ModAPI.API.AddLuaOpenListener(() => {
                OnLuaOpen?.Invoke();

                return 0;
            });

            ModAPI.API.AddBltListener((S4BltParams* bltParams, int discard) => {
                OnBlt?.Invoke(new IntPtr(bltParams), discard != 0);

                return 0;
            });

            ModAPI.API.AddGuiBltListener((S4GuiBltParams* bltParams, int discard) => {
                OnGuiBlt?.Invoke(new IntPtr(bltParams), discard != 0);

                return 0;
            });

            ModAPI.API.AddEntityListener((ushort entity, S4_ENTITY_CAUSE cause) => {
                OnEntity?.Invoke(entity, (ushort)cause);

                return 0;
            });

            ModAPI.API.AddGuiElementBltListener((S4GuiElementBltParams* bltParams, int discard) => {
                OnGuiDraw?.Invoke(new IntPtr(bltParams), discard != 0);

                return 0;
            });

            ModAPI.API.AddGuiClearListener((S4GuiClearParams* bltParams, int discard) => {
                OnGuiClear?.Invoke(new IntPtr(bltParams), discard != 0);

                return 0;
            });


        }
    }
}
