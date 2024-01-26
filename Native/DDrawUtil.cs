using Forge.Logging;
using Forge.S4;

using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using DirectDraw7 = Microsoft.DirectX.DirectDraw.Device;
using DirectDrawSurface7 = Microsoft.DirectX.DirectDraw.Surface;
//using SurfaceDescription = Microsoft.DirectX.DirectDraw.SurfaceDescription;

namespace Forge.Native {
    public static unsafe class DDrawUtil {

        private static DirectDraw7? device;

        static DDrawUtil() {
            FetchDevice();
        }

        public static void FetchDevice() {
            IDirectDraw* ddrawDevice = (IDirectDraw*)GameValues.ReadValue<int>(0x1057F7C);
            if ((int)ddrawDevice == 0) {
                throw new ArgumentNullException("ddrawDevice", "Failed to retrieve DirectDraw7 device from settlers 4");
            }

            device = new DirectDraw7(ddrawDevice);
        }

        public static DirectDrawSurface7? SurfaceFromPointer(IDirectDrawSurface7* surface) {
            return new DirectDrawSurface7(surface);
        }

    }
}
