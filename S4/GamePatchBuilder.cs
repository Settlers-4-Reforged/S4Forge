using NetModAPI;

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

using APICallPatch = NetModAPI.CallPatch;
using APIJumpPatch = NetModAPI.JmpPatch;
using APINopPatch = NetModAPI.NopPatch;
using APIPatch = NetModAPI.Patch;

namespace Forge.S4 {
    public abstract class GamePatchBuilder<T> where T : GamePatchBuilder<T> {
        // ReSharper disable once InconsistentNaming
        private static int S4_Main => GameValues.S4_Main;

        protected IntPtr? sourceAddress;
        public T At(int address) {
            sourceAddress = new IntPtr(address);
            return (T)this;
        }
        public T AtS4(int address) {
            sourceAddress = new IntPtr(address + S4_Main);
            return (T)this;
        }

        protected byte[]? expectedBytes;
        public T ExpectedBytes(params byte[] expectedSourceBytes) {
            this.expectedBytes = expectedSourceBytes;
            return (T)this;
        }

        public void ValidateRequiredValues() {
            if (sourceAddress == null) {
                throw new InvalidOperationException("Source address must be set");
            }
        }

        public abstract GamePatch Build();
    }

    public sealed class PatchBuilder : GamePatchBuilder<PatchBuilder> {
        private byte[]? patchBytes;
        public PatchBuilder PatchBytes(params byte[] patch) {
            this.patchBytes = patch;
            return this;
        }

        public override GamePatch Build() {
            ValidateRequiredValues();

            if (patchBytes == null) {
                throw new InvalidOperationException("Patch bytes must be set");
            }

            APIPatch patch;
            if (expectedBytes != null)
                patch = new APIPatch(sourceAddress!.Value.ToInt32(), patchBytes, expectedBytes);
            else
                patch = new APIPatch(sourceAddress!.Value.ToInt32(), patchBytes);

            return new GamePatch(patch);
        }
    }

    public sealed class CallPatchBuilder : GamePatchBuilder<CallPatchBuilder> {
        private IntPtr? destinationAddress;
        public CallPatchBuilder To(int address) {
            destinationAddress = new IntPtr(address);
            return this;
        }
        public CallPatchBuilder ToS4(int address) {
            destinationAddress = new IntPtr(address + GameValues.S4_Main);
            return this;
        }

        public CallPatchBuilder ToDelegate(Delegate destination) {
            destinationAddress = Marshal.GetFunctionPointerForDelegate(destination);
            return this;
        }

        private int nops = 0;
        public CallPatchBuilder AddNops(int length) {
            this.nops = length;
            return this;
        }

        public override GamePatch Build() {
            ValidateRequiredValues();

            if (destinationAddress == null) {
                throw new InvalidOperationException("Destination address must be set");
            }

            APIJumpPatch patch;
            if (expectedBytes != null)
                patch = new APIJumpPatch(sourceAddress!.Value, destinationAddress.Value, expectedBytes, nops);
            else
                patch = new APIJumpPatch(sourceAddress!.Value, destinationAddress.Value, nops);

            return new GamePatch(patch);
        }
    }

    public sealed class NopPatchBuilder : GamePatchBuilder<NopPatchBuilder> {
        private int? length;
        public NopPatchBuilder Length(int length) {
            this.length = length;
            return this;
        }

        public override GamePatch Build() {
            ValidateRequiredValues();

            if (length == null) {
                throw new InvalidOperationException("Length must be set");
            }

            APINopPatch patch;
            if (expectedBytes != null)
                patch = new APINopPatch(sourceAddress!.Value, expectedBytes, length.Value);
            else
                patch = new APINopPatch(sourceAddress!.Value, length.Value);

            return new GamePatch(patch);
        }
    }

    public readonly struct GamePatch : IDisposable {
        private readonly IPatch handle;
        internal GamePatch(IPatch handle) {
            this.handle = handle;
        }

        public void Apply() {
            handle.Apply();
        }

        public void Revert() {
            handle.Revert();
        }

        public void Dispose() {
            handle.Dispose();
        }
    }
}
