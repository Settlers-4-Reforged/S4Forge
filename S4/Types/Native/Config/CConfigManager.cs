using Forge.S4.Types;
using Forge.S4.Types.Native.Helpers;
using System.Runtime.CompilerServices;

namespace Forge.S4.Types.Native.Config
{
    public unsafe partial struct CConfigManager : CConfigManager.Interface
    {
        public void** lpVtbl;

        [NativeInheritance(nameof(CConfigManager))]
        public ConfigVarMap* definitionsList;

        [NativeInheritance(nameof(CConfigManager))]
        public int field_8;

        [NativeInheritance(nameof(CConfigManager))]
        public ConfigSectionList sectionList;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public CConfigManager* dtor([NativeTypeName("char")] sbyte param0)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigManager*, sbyte, CConfigManager*>)(lpVtbl[0]))((CConfigManager*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public int sub_2275E0(int param0)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigManager*, int, int>)(lpVtbl[1]))((CConfigManager*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("char")]
        public sbyte sub_227350([NativeTypeName("const char *")] sbyte* param0, int param1, int param2)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigManager*, sbyte*, int, int, sbyte>)(lpVtbl[2]))((CConfigManager*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public int RetrieveIntSetting([NativeTypeName("const char *")] sbyte* section, [NativeTypeName("const char *")] sbyte* config, int defaultValue)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigManager*, sbyte*, sbyte*, int, int>)(lpVtbl[3]))((CConfigManager*)Unsafe.AsPointer(ref this), section, config, defaultValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public double RetrieveFloatSetting([NativeTypeName("const char *")] sbyte* section, [NativeTypeName("const char *")] sbyte* config, float defaultValue)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigManager*, sbyte*, sbyte*, float, double>)(lpVtbl[4]))((CConfigManager*)Unsafe.AsPointer(ref this), section, config, defaultValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public wstring* RetrieveStringSetting(wstring* @out, [NativeTypeName("const char *")] sbyte* section, [NativeTypeName("const char *")] sbyte* config, wstring* defaultValue)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigManager*, wstring*, sbyte*, sbyte*, wstring*, wstring*>)(lpVtbl[5]))((CConfigManager*)Unsafe.AsPointer(ref this), @out, section, config, defaultValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public CConfigVar* GetConfigVar([NativeTypeName("const char *")] sbyte* section, [NativeTypeName("const char *")] sbyte* config)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigManager*, sbyte*, sbyte*, CConfigVar*>)(lpVtbl[6]))((CConfigManager*)Unsafe.AsPointer(ref this), section, config);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void sub_228A40(int a2, int a3)
        {
            ((delegate* unmanaged[Thiscall]<CConfigManager*, int, int, void>)(lpVtbl[7]))((CConfigManager*)Unsafe.AsPointer(ref this), a2, a3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public CConfigVarMapNode* FindDefinition(wstring* a2)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigManager*, wstring*, CConfigVarMapNode*>)(lpVtbl[8]))((CConfigManager*)Unsafe.AsPointer(ref this), a2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("char")]
        public sbyte ReadSectionFromFile([NativeTypeName("const char *")] sbyte* section, int* file)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigManager*, sbyte*, int*, sbyte>)(lpVtbl[9]))((CConfigManager*)Unsafe.AsPointer(ref this), section, file);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public int SettingsCountInSection([NativeTypeName("const char *")] sbyte* section)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigManager*, sbyte*, int>)(lpVtbl[10]))((CConfigManager*)Unsafe.AsPointer(ref this), section);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public bool IsConfigDefined([NativeTypeName("const char *")] sbyte* section, [NativeTypeName("const char *")] sbyte* config)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigManager*, sbyte*, sbyte*, byte>)(lpVtbl[11]))((CConfigManager*)Unsafe.AsPointer(ref this), section, config) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void ChangeConfig([NativeTypeName("const char *")] sbyte* category, [NativeTypeName("const char *")] sbyte* setting, CConfigVar* variable)
        {
            ((delegate* unmanaged[Thiscall]<CConfigManager*, sbyte*, sbyte*, CConfigVar*, void>)(lpVtbl[12]))((CConfigManager*)Unsafe.AsPointer(ref this), category, setting, variable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public int sub_228EA0([NativeTypeName("const char *")] sbyte* arg0, [NativeTypeName("const char *")] sbyte* param1, int param2)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigManager*, sbyte*, sbyte*, int, int>)(lpVtbl[13]))((CConfigManager*)Unsafe.AsPointer(ref this), arg0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public double sub_2291C0([NativeTypeName("const char *")] sbyte* arg0, [NativeTypeName("const char *")] sbyte* param1, float param2)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigManager*, sbyte*, sbyte*, float, double>)(lpVtbl[14]))((CConfigManager*)Unsafe.AsPointer(ref this), arg0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("DWORD *")]
        public uint* sub_229530([NativeTypeName("DWORD *")] uint* arg0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("DWORD *")] uint* param3)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigManager*, uint*, sbyte*, sbyte*, uint*, uint*>)(lpVtbl[15]))((CConfigManager*)Unsafe.AsPointer(ref this), arg0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("char")]
        public sbyte sub_227530([NativeTypeName("wchar_t *")] ushort* a1, int a2)
        {
            return ((delegate* unmanaged[Thiscall]<CConfigManager*, ushort*, int, sbyte>)(lpVtbl[16]))((CConfigManager*)Unsafe.AsPointer(ref this), a1, a2);
        }

        public interface Interface
        {
            [VtblIndex(0)]
            CConfigManager* dtor([NativeTypeName("char")] sbyte param0);

            [VtblIndex(1)]
            int sub_2275E0(int param0);

            [VtblIndex(2)]
            [return: NativeTypeName("char")]
            sbyte sub_227350([NativeTypeName("const char *")] sbyte* param0, int param1, int param2);

            [VtblIndex(3)]
            int RetrieveIntSetting([NativeTypeName("const char *")] sbyte* section, [NativeTypeName("const char *")] sbyte* config, int defaultValue);

            [VtblIndex(4)]
            double RetrieveFloatSetting([NativeTypeName("const char *")] sbyte* section, [NativeTypeName("const char *")] sbyte* config, float defaultValue);

            [VtblIndex(5)]
            wstring* RetrieveStringSetting(wstring* @out, [NativeTypeName("const char *")] sbyte* section, [NativeTypeName("const char *")] sbyte* config, wstring* defaultValue);

            [VtblIndex(6)]
            CConfigVar* GetConfigVar([NativeTypeName("const char *")] sbyte* section, [NativeTypeName("const char *")] sbyte* config);

            [VtblIndex(7)]
            void sub_228A40(int a2, int a3);

            [VtblIndex(8)]
            CConfigVarMapNode* FindDefinition(wstring* a2);

            [VtblIndex(9)]
            [return: NativeTypeName("char")]
            sbyte ReadSectionFromFile([NativeTypeName("const char *")] sbyte* section, int* file);

            [VtblIndex(10)]
            int SettingsCountInSection([NativeTypeName("const char *")] sbyte* section);

            [VtblIndex(11)]
            bool IsConfigDefined([NativeTypeName("const char *")] sbyte* section, [NativeTypeName("const char *")] sbyte* config);

            [VtblIndex(12)]
            void ChangeConfig([NativeTypeName("const char *")] sbyte* category, [NativeTypeName("const char *")] sbyte* setting, CConfigVar* variable);

            [VtblIndex(13)]
            int sub_228EA0([NativeTypeName("const char *")] sbyte* arg0, [NativeTypeName("const char *")] sbyte* param1, int param2);

            [VtblIndex(14)]
            double sub_2291C0([NativeTypeName("const char *")] sbyte* arg0, [NativeTypeName("const char *")] sbyte* param1, float param2);

            [VtblIndex(15)]
            [return: NativeTypeName("DWORD *")]
            uint* sub_229530([NativeTypeName("DWORD *")] uint* arg0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("DWORD *")] uint* param3);

            [VtblIndex(16)]
            [return: NativeTypeName("char")]
            sbyte sub_227530([NativeTypeName("wchar_t *")] ushort* a1, int a2);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("CConfigManager *(char) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte, CConfigManager*> dtor;

            [NativeTypeName("int (int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int> sub_2275E0;

            [NativeTypeName("char (const char *, int, int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte*, int, int, sbyte> sub_227350;

            [NativeTypeName("int (const char *, const char *, int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte*, sbyte*, int, int> RetrieveIntSetting;

            [NativeTypeName("double (const char *, const char *, float) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte*, sbyte*, float, double> RetrieveFloatSetting;

            [NativeTypeName("wstring *(wstring *, const char *, const char *, wstring *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, wstring*, sbyte*, sbyte*, wstring*, wstring*> RetrieveStringSetting;

            [NativeTypeName("CConfigVar *(const char *, const char *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte*, sbyte*, CConfigVar*> GetConfigVar;

            [NativeTypeName("void (int, int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, int, int, void> sub_228A40;

            [NativeTypeName("CConfigVarMapNode *(wstring *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, wstring*, CConfigVarMapNode*> FindDefinition;

            [NativeTypeName("char (const char *, int *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte*, int*, sbyte> ReadSectionFromFile;

            [NativeTypeName("int (const char *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte*, int> SettingsCountInSection;

            [NativeTypeName("bool (const char *, const char *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte*, sbyte*, byte> IsConfigDefined;

            [NativeTypeName("void (const char *, const char *, CConfigVar *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte*, sbyte*, CConfigVar*, void> ChangeConfig;

            [NativeTypeName("int (const char *, const char *, int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte*, sbyte*, int, int> sub_228EA0;

            [NativeTypeName("double (const char *, const char *, float) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, sbyte*, sbyte*, float, double> sub_2291C0;

            [NativeTypeName("DWORD *(DWORD *, const char *, const char *, DWORD *) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, uint*, sbyte*, sbyte*, uint*, uint*> sub_229530;

            [NativeTypeName("char (wchar_t *, int) __attribute__((thiscall))")]
            public delegate* unmanaged[Thiscall]<TSelf*, ushort*, int, sbyte> sub_227530;
        }
    }
}
