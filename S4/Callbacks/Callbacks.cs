using Forge.Native;
using Forge.S4.Types;

using Microsoft.DirectX.DirectDraw;

using NetModAPI;

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

using DirectDrawSurface = Microsoft.DirectX.DirectDraw.Surface;

namespace Forge.S4.Callbacks {
    public class Callbacks {

        #region Delegates

        public delegate void GameFrameCallback(DirectDrawSurface? surface, int pillarBoxWidth);
        public delegate void MapInitCallback();
        public unsafe delegate void MouseCallbackUnsafe(uint mouseButton, int x, int y, uint msgId, S4UIElement* uiElement);
        public delegate void MouseCallback(uint mouseButton, int x, int y, uint msgId, S4UIElement? uiElement);
        public delegate void SettlerSendCallback(uint position, uint command);
        public delegate void TickCallback(uint tick, bool hasEvent, bool isDelayed);
        public delegate void LuaOpenCallback();
        public delegate void DrawEntityCallback(S4EntityDrawParams parameter, bool discard);
        public delegate void SurfaceDrawCallback(IntPtr bltParams, bool discard);
        public delegate void EntityCallback(ushort entity, ushort cause);
        public delegate void UIElementDrawCallback(S4UIElementDrawParams bltParams, S4UIElement? uiElement, bool discard);
        public unsafe delegate void UIElementDrawCallbackUnsafe(S4UIElementDrawParams bltParams, S4UIElement* uiElement, bool discard);
        public delegate void SurfaceClearCallback(IntPtr bltParams, bool discard);

        #endregion

        #region Initializations

        /// <summary>
        /// Event that is called when the map is initialized.
        /// </summary>
        public event MapInitCallback? OnMapInit;

        /// <summary>
        /// Event that is called when a map script is opened.
        /// </summary>
        public event LuaOpenCallback? OnLuaOpen;

        #endregion

        #region Interaction

        /// <summary>
        /// Event that is called when the mouse is clicked.
        /// </summary>
        public event MouseCallback? OnMouse;
        /// <summary>
        /// Event that is called when the mouse is clicked.
        /// UI element pointer to game memory is passed.
        /// </summary>
        public event MouseCallbackUnsafe? OnMouseUnsafe;

        #endregion

        #region InGameEvents

        /// <summary>
        /// Event that is called when a settler move command is sent.
        /// </summary>
        public event SettlerSendCallback? OnSettlerSend;

        /// <summary>
        /// Event that is called every tick.
        /// </summary>
        public event TickCallback? OnTick;

        /// <summary>
        /// Event that is called when an entity is spawned or destructed.
        /// </summary>
        public event EntityCallback? OnEntity;

        #endregion

        #region Rendering
        /// <summary>
        /// Event that is called every frame.
        /// </summary>
        public event GameFrameCallback? OnFrame;

        /// <summary>
        /// Event that is called when any "in-world" element is drawn.
        /// </summary>
        public event DrawEntityCallback? OnDrawEntity;

        /// <summary>
        /// Event that is called when a gui surface is drawn onto the screen.
        /// </summary>
        public event SurfaceDrawCallback? OnSurfaceDraw;

        /// <summary>
        /// Event that is called when a gui element is drawn onto a gui surface.
        /// </summary>
        public event UIElementDrawCallback? OnUIElementDraw;

        /// <summary>
        /// Event that is called when a gui element is drawn onto a gui surface.
        /// UI element pointer to game memory is passed.
        /// </summary>
        public event UIElementDrawCallbackUnsafe? OnUIElementDrawUnsafe;

        /// <summary>
        /// Event that is called when a gui surface is cleared.
        /// </summary>
        public event SurfaceClearCallback? OnSurfaceClear;

        #endregion


        unsafe Callbacks() {
            ModAPI.API.AddFrameListener((surface, width, reserved) => {
                using Surface? directDrawSurface = DDrawUtil.SurfaceFromPointer(surface);

                OnFrame?.Invoke(directDrawSurface, width);
                //once reserved is no longer unused, add new version of OnFrame

                return 0;
            });

            ModAPI.API.AddMapInitListener((reserved0, reserved1) => {
                OnMapInit?.Invoke();
                //once reserved0 or reserved1 is no longer unused, add new version of OnMapInit

                return 0;
            });

            ModAPI.API.AddMouseListener((mouseButton, x, y, msgId, hwnd, uiElement) => {
                OnMouse?.Invoke(mouseButton, x, y, msgId, uiElement == null ? null : Marshal.PtrToStructure<S4UIElement>(new IntPtr(uiElement)));
                OnMouseUnsafe?.Invoke(mouseButton, x, y, msgId, (S4UIElement*)uiElement);

                return 0;
            });

            ModAPI.API.AddSettlerSendListener((position, command, reserved) => {
                OnSettlerSend?.Invoke(position, (uint)command);
                //once reserved is no longer unused, add new version of OnSettlerSend

                return 0;
            });

            ModAPI.API.AddTickListener((tick, hasEvent, isDelayed) => {
                OnTick?.Invoke(tick, hasEvent != 0, isDelayed != 0);

                return 0;
            });

            ModAPI.API.AddLuaOpenListener(() => {
                OnLuaOpen?.Invoke();

                return 0;
            });

            ModAPI.API.AddBltListener((bltParams, discard) => {
                OnDrawEntity?.Invoke(Marshal.PtrToStructure<S4EntityDrawParams>(new IntPtr(bltParams)), discard != 0);

                return 0;
            });

            ModAPI.API.AddGuiBltListener((bltParams, discard) => {
                OnSurfaceDraw?.Invoke(new IntPtr(bltParams), discard != 0);

                return 0;
            });

            ModAPI.API.AddEntityListener((entity, cause) => {
                OnEntity?.Invoke(entity, (ushort)cause);

                return 0;
            });

            ModAPI.API.AddGuiElementBltListener((bltParams, discard) => {
                var param = Marshal.PtrToStructure<S4UIElementDrawParams>(new IntPtr(bltParams));

                S4UIElement* uiElement = GameValues.GetUIElementFromIndexUnsafe(param.elementContainerId, param.valueLink);

                OnUIElementDraw?.Invoke(param, uiElement == null ? null : *uiElement, discard != 0);
                OnUIElementDrawUnsafe?.Invoke(param, uiElement, discard != 0);

                return 0;
            });

            ModAPI.API.AddGuiClearListener((bltParams, discard) => {
                OnSurfaceClear?.Invoke(new IntPtr(bltParams), discard != 0);

                return 0;
            });


        }
    }
}
