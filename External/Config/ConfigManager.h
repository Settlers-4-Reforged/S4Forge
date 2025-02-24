#pragma once

typedef unsigned int DWORD;

struct wstring {
    wchar_t* text;
    int size;
    int capacity;
    int field_0C;
    int capacity_;
    int field_14;
};


// Base Types:
struct CConfigVar {
    char field_4;
    char type;
    char itemCount;
    char field_7;

    virtual int GetValue();
    virtual double GetValueAsDouble();
    virtual DWORD ResetString(wstring* name);
    virtual int *GetArray();
    virtual int *GetList();
    virtual void nullsub_508(int a1);
    virtual void nullsub_509(int a1);
    virtual void SetValueFromFloat(float value);
    virtual void SetValueFromInt(int a1);
    virtual DWORD* DestroyConfigVar(char a2);
};

struct CDynamicConfigVar : public CConfigVar {
};

struct CStaticConfigVar : private CConfigVar {
};

// ConfigVar Types:

struct CConfigVarFloat : public CDynamicConfigVar {
    float value;
};

struct CConfigVarInt : public CDynamicConfigVar {
    int value;
};

struct CConfigVarString : public CDynamicConfigVar {
    wstring value;
};

// Static ConfigVar Types:
struct CStaticConfigVarFloat : public CStaticConfigVar {
    float value;
};

struct CStaticConfigVarInt : public CStaticConfigVar {
    int value;
};


struct CStaticConfigVarString : public CStaticConfigVar {
    wstring value;
};

// AI ConfigVar Types:
struct CAIConfigIntEx : public CStaticConfigVar {
    int value[3];
};
//template <class TNode>
//class CList {
//    TNode* start;
//    int length;
//};


//
//template <class Key, class Value>
//class CMapPair {
//    Key key;
//    Value value;
//};

//template <class TMapPair>
//class CMapNode {
//    CMapNode* parent;   // == NIL if root of the tree
//    CMapNode* child[2]; // == NIL if child is empty
//    // The index is:
//    //   LEFT  := 0, if (key < parent->key)
//    //   RIGHT := 1, if (key > parent->key)
//
//    TMapPair data;
//    int depth;
//};
//
//template <class TMapNode>
//class CMap {
//    TMapNode *root;
//    int size;
//};

struct CConfigVarMapNode {
    CConfigVarMapNode* parent;   // == NIL if root of the tree
    CConfigVarMapNode* left; // == NIL if child is empty
    CConfigVarMapNode* right; // == NIL if child is empty
    // The index is:
    //   LEFT  := 0, if (key < parent->key)
    //   RIGHT := 1, if (key > parent->key)

    char unk_12;
    char isUnpopulatedNode;
    short unk_14;
    wstring key;
    CConfigVar* value;
};

//typedef CMap<wstring, CConfigVar*> ConfigVarMap;
struct ConfigVarMap {
    CConfigVarMapNode* root;
    int size;
};


struct CConfigSection {
    wstring name;
    ConfigVarMap configVarMap;
};

//template <class T>
//struct CListNode {
//    CListNode<T>* next;
//    CListNode<T>* prev;
//    T data;
//};

struct CConfigSectionListNode {
    CConfigSectionListNode* next;
    CConfigSectionListNode* prev;
    CConfigSection* data;
};
struct ConfigSectionList {
    CConfigSectionListNode* start;
    int length;
};

//
//int __thiscall SetIntConfigValue(CConfigSection* This, wstring* name, int a3);
//int __thiscall SetFloatConfigValue(CConfigSection* This, wstring* name, float a3 /*@XMM2*/);
//int __thiscall SetStringConfigValue(CConfigSection* This, wstring* name, wstring* a3);


// ConfigManager found at: 0x1054C8C
struct CConfigManager {
    ConfigVarMap* definitionsList;
    int field_8;
    ConfigSectionList sectionList;

    virtual CConfigManager* dtor(char); ///< -> 00226720, args: 0x4
    virtual int sub_2275E0(int); ///< -> 002275E0, args: 0x4
    virtual char sub_227350(const char*, int, int); ///< -> 00227350, args: 0xC
    virtual int RetrieveIntSetting(const char* section, const char* config, int defaultValue); ///< -> 00228CF0, args: 0xC
    virtual double RetrieveFloatSetting(const char* section, const char* config, float defaultValue); ///< -> 00229010, args: 0xC
    virtual wstring* RetrieveStringSetting(wstring* out, const char* section, const char* config, wstring* defaultValue); ///< -> 00229330, args: 0x10
    virtual CConfigVar* GetConfigVar(const char* section, const char* config); ///< -> 00227600, args: 0x8
    virtual void sub_228A40(int a2, int a3);
    virtual CConfigVarMapNode* FindDefinition(wstring* a2);
    virtual char ReadSectionFromFile(const char* section, int/*CFile*/* file);
    virtual int SettingsCountInSection(const char* section);
    virtual bool IsConfigDefined(const char* section, const char* config);
    virtual void ChangeConfig(const char* category, const char* setting, CConfigVar* variable);
    virtual int sub_228EA0(const char* arg0, const char*, int);
    virtual double sub_2291C0(const char* arg0, const char*, float);
    virtual DWORD* sub_229530(DWORD* arg0, const char*, const char*, DWORD*);
    virtual char sub_227530(wchar_t* a1, int a2 /* -> 002291C0, args: 0xC */);
};
