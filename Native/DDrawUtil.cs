using Forge.Logging;
using Forge.S4;
using Forge.UX.Native;

using Microsoft.DirectX.Direct3D;
using Microsoft.DirectX.DirectDraw;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

using DirectDraw7 = Microsoft.DirectX.DirectDraw.Device;
using DirectDrawSurface7 = Microsoft.DirectX.DirectDraw.Surface;
using SurfaceDescription = Microsoft.DirectX.DirectDraw.SurfaceDescription;

namespace Forge.Native {
    public static unsafe class DDrawUtil {

        private static DirectDraw7? device;
        private static Assembly DDrawAssembly { get; } = Assembly.GetAssembly(typeof(DirectDraw7));

        private static Type IDirectDraw7Type { get; } = DDrawAssembly.GetType("IDirectDraw7");
        private static Type IDirectDrawSurface7Type { get; } = DDrawAssembly.GetType("IDirectDrawSurface7");

        private static ConstructorInfo IDirectDrawSurface7Constructor { get; }
        private static ConstructorInfo IDirectDraw7Constructor { get; }

        static DDrawUtil() {
            {
                Type type = typeof(DirectDrawSurface7);
                var constructors = type.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);
                IDirectDrawSurface7Constructor =
                    constructors.First(info => info.GetParameters()[1].ParameterType == typeof(DirectDraw7));
            }
            {
                Type type = typeof(DirectDraw7);
                IDirectDraw7Constructor = type.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic).First();
            }

            FetchDevice();
        }

        public static void FetchDevice() {
            void* ddrawDevice = (void*)GameValues.ReadValue<int>(0x1057F7C);
            if ((int)ddrawDevice == 0) {
                throw new ArgumentNullException("ddrawDevice", "Failed to retrieve DirectDraw7 device from settlers 4");
            }

            device = (DirectDraw7)IDirectDraw7Constructor.Invoke(new[] { Pointer.Box(ddrawDevice, IDirectDraw7Type.MakePointerType()) });
            SurfaceDescription? test = device.DisplayMode;
            GC.SuppressFinalize(device); //Device has a dispose function that destroys the device - not our device = please don't dispose
        }

        public static DirectDrawSurface7? SurfaceFromPointer(IDirectDrawSurface7* surface) {

            DirectDrawSurface7? texture = (DirectDrawSurface7)IDirectDrawSurface7Constructor.Invoke(new[] { Pointer.Box(surface, IDirectDrawSurface7Type.MakePointerType()), device });
            texture.Disposing += (sender, args) => {
                DirectDrawSurface7 sTexture = (DirectDrawSurface7)sender;

                Type type = typeof(DirectDrawSurface7);
                //Surface has a dispose function that destroys the surface - not our surface = please don't dispose these resources:
                type.GetField("parentObject", BindingFlags.Instance | BindingFlags.NonPublic)?.SetValue(sTexture, null);
                type.GetField("m_lpUM", BindingFlags.Instance | BindingFlags.NonPublic)?.SetValue(sTexture, null);

                //But we still want a dispose, to delete created gdi objects like brushes etc.
            };

            return texture;
        }

    }


    // Because the DirectX 7 Managed API is build with Framework v1.1 this is needed:
    public static class RuntimePolicyHelper {
        public static bool LegacyV2RuntimeEnabledSuccessfully { get; private set; }

        static RuntimePolicyHelper() {
            ICLRRuntimeInfo clrRuntimeInfo =
                (ICLRRuntimeInfo)RuntimeEnvironment.GetRuntimeInterfaceAsObject(
                    Guid.Empty,
                    typeof(ICLRRuntimeInfo).GUID);
            try {
                clrRuntimeInfo.BindAsLegacyV2Runtime();
                LegacyV2RuntimeEnabledSuccessfully = true;
            } catch (COMException) {
                // This occurs with an HRESULT meaning 
                // "A different runtime was already bound to the legacy CLR version 2 activation policy."
                LegacyV2RuntimeEnabledSuccessfully = false;
            }
        }

        [ComImport]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        [Guid("BD39D1D2-BA2F-486A-89B0-B4B0CB466891")]
        private interface ICLRRuntimeInfo {
            void xGetVersionString();
            void xGetRuntimeDirectory();
            void xIsLoaded();
            void xIsLoadable();
            void xLoadErrorString();
            void xLoadLibrary();
            void xGetProcAddress();
            void xGetInterface();
            void xSetDefaultStartupFlags();
            void xGetDefaultStartupFlags();

            [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
            void BindAsLegacyV2Runtime();
        }
    }
}
