#pragma once

#include "s4.h"

class ISettlerRole : public CPersistance {
    /* + 4 S */ CHAR unk_04;
    /* + 5 S */ BYTE unk_05;
    /* + 6 S */ BYTE walkspeed; // in ticks per field
    /* + 7 S */ BYTE unk_07;
    /* + 8 S */ WORD unk_08;
    /* + 10 S */ BYTE unk_0A;
    /* + 11 S */ BYTE unk_0B;
    /* + 12 S */ BYTE unk_0C;
    /* + 13 _ */ BYTE pad_0D;
    /* + 14 S */ WORD unk_0E;
    /* + 16 S */ WORD unk_10;
    /* + 18 S */ WORD unk_12;
    /* + 20 S */ WORD unk_14;
    /* + 22 _ */ WORD pad_16;
    /* + 24 S */ DWORD unk_18;
    /* + 28 S */ DWORD unk_1C;
    /* + 32 S */ WORD unk_20;
    /* + 34 S */ WORD unk_22;
    /* + 36 _ */ WORD unk_24;
    /* + 38 _ */ WORD unk_26;
    /* + 40 _ */ WORD unk_28;
    /* + 42 _ */ WORD unk_2A;

    virtual ISettlerRole* vfunc2(BYTE) = 0;
    virtual DWORD vfunc3() = 0; // todo: type me
    virtual VOID walk(LPVOID) = 0; // this may also check the landscape to adjust the walk speed, it will also register for logic update
    virtual DWORD vfunc5() = 0; // todo: type me
    virtual VOID vfunc6(LPVOID) = 0; // may call register logic update
    virtual DWORD vfunc7() = 0; // todo: type me
    virtual VOID vfunc8() = 0;
    virtual DWORD vfunc9() = 0; // todo: type me
    virtual DWORD vfunc10() = 0; // todo: type me
    virtual DWORD vfunc11() = 0; // todo: type me
    virtual VOID vfunc12(WORD) = 0; // setter for unk_20
    virtual VOID vfunc13(WORD) = 0; // setter for unk_22
    virtual DWORD vfunc14() = 0; // todo: type me
    virtual DWORD vfunc15(INT) = 0; // this accesses a map
    virtual DWORD vfunc16(INT*) = 0;
    virtual DWORD vfunc17(DWORD) = 0; // may return the only param
    virtual DWORD vfunc18() = 0; // todo: type me
    virtual BYTE vfunc19() = 0; // may return 0
    virtual VOID vfunc20(INT, WORD) = 0; // setter for unk_20 and unk_14
    virtual DWORD vfunc21(INT) = 0; // getter for unk_20 and unk_14
    virtual DWORD vfunc22() = 0; // may return 0
    virtual DWORD vfunc23() = 0; // may return 0
    virtual DWORD vfunc24() = 0; // may return 0
    virtual DWORD vfunc25() = 0; // may return 0
    virtual DWORD vfunc26() = 0; // may return 0
    virtual DWORD vfunc27() = 0; // may return 1
    virtual DWORD vfunc28() = 0; // may return 0
    virtual BYTE vfunc29() = 0;  // may return 0
    virtual DWORD vfunc30(INT, INT) = 0; // accesses the map
    virtual BYTE vfunc31(LPVOID) = 0;
    virtual VOID vfunc32(INT, INT**, WORD, WORD, DWORD) = 0;
};
class IBuildingRole : public CPersistance {
    // todo
};
class IPileRole : public CPersistance {
    // todo
};
// todo: role subclassing
struct IEntity : public CPersistance {
    /* + 4 S */ DWORD id; // entity id (index of self in the entity pool)
    /* + 8 S */ WORD id2;
    /* +10 S */
    enum EntityType : BYTE {
        Settler = 1,
        Ship = 2,
        Landvehicle = 4,
        Building = 8,
        Good = 16,
        Plant = 32, // tree, wheat, sunflower plant, grasses etc
        Unknown = 64,
        Animal = 128,// bunny, deer, etc bytes;
    } entityType;
    /* +11 _ */ BYTE unk0; // unused alignment byte (?)
    /* +12 S */ WORD objectId; // this is the settler/building id etc
    /* +14 _ */ BYTE unk1[6]; // unused bytes (?), none of them are serialized
    /* +20 S */
    enum BaseType : BYTE {
        Civilian = 0, // civilian building or object like wheat plant etc (wheatplant has settlerType == 209 and goodtype == 0)
        Swordman = 2,
        Bowman,
        Racespecial,
        Leader,
        Priest,
        Paramilitary, // thief, pioneer etc
        Warmachine,
        Tradingcart, // 
        Warship,
        CivilianShip,
        MilitaryBuilding, // (?)
        Donkey = 14, // 
        Other = 64, // good or settler
    } baseType;
    /* +21 S */ BYTE selectionFlags;
    /* +22 S */ BYTE unk2;
    /* +23 S */ BYTE unk3;
    /* +24 S */ WORD x;
    /* +26 S */ WORD y;
    /* +28 _ */ BYTE unk5;
    /* +29 _ */ BYTE unk6;
    /* +30 _ */ WORD unk7;
    /* +32 S */ struct {
        BYTE tribe : 4; // only the 4 most significant bits are the player, todo: confirm it
        BYTE player : 4; // only the 4 least significant bits are the tribe
#pragma warning(suppress: 4201) // supress unnamed structures
    };
    /* +33 S */ BYTE health;
    /* +34 _ */ BYTE pad0;
    /* +35 _ */ BYTE pad1;

    virtual IEntity* vfunc2(LPVOID) = 0; // probably some kind of destroy/dispose method
    virtual DWORD clearSelection() = 0;
    virtual VOID vfunc4() = 0; // something with map access
    virtual LPVOID vfunc5() = 0;
    virtual DWORD PopulateRenderData(INT) = 0; // Populates the render data object with the current state of the entity
    virtual VOID vfunc7(DWORD, DWORD) = 0;
    virtual VOID vfunc8(DWORD) = 0;
    virtual VOID vfunc9() = 0;
    virtual DWORD vfunc10() = 0; // simple getter for buildings
    virtual DWORD vfunc11() = 0; // returns always 0 for buildings
    virtual VOID vfunc12() = 0; // does nothing for buildings
    virtual VOID vfunc13(INT) = 0;
    virtual VOID vfunc14() = 0;
    virtual DWORD vfunc15() = 0;  // returns always 0 for buildings
    virtual DWORD vfunc16() = 0;  // returns always 0 for buildings
    virtual VOID vfunc17(INT, INT) = 0;
    virtual DWORD vfunc18(INT) = 0;
    virtual VOID vfunc19() = 0;
    virtual VOID vfunc20(DWORD) = 0;
    virtual DWORD vfunc21() = 0;  // returns always 0 for buildings
    virtual DWORD vfunc22() = 0;  // returns always 0 for buildings
    virtual DWORD vfunc23() = 0;  // returns always 0 for buildings
    virtual DWORD vfunc24() = 0;  // returns always 0 for buildings

    //EntityClass GetClass() {
    //    switch ((DWORD)GetVtable() - S4_Main) {
    //        // todo: the following offsets work only for version with md5 c13883cbd796c614365ab2d670ead561
    //    case 0xc585e4: return EntityClass::Building;
    //    case 0xc5a7bc: return EntityClass::Pile;
    //    case 0xc5bf20: return EntityClass::Settler;
    //    case 0xc5821c: return EntityClass::Landanimal;
    //    case 0xc59710: return EntityClass::Cart;
    //    case 0xc59814: return EntityClass::CatapultMaya;
    //    case 0xc59918: return EntityClass::CatapultTrojan;
    //    case 0xc59a1c: return EntityClass::CatapultRoman;
    //    case 0xc59b20: return EntityClass::CatapultViking;
    //    case 0xc5c60c: return EntityClass::Ferry;
    //    case 0xc5c81c: return EntityClass::Transportship;
    //    case 0xc5c8fc: return EntityClass::WarshipMaya;
    //    case 0xc5ca10: return EntityClass::WarshipTrojan;
    //    case 0xc5cb0c: return EntityClass::WarshipRoman;
    //    case 0xc5cc20: return EntityClass::WarshipViking;
    //    case 0xc5a3b8: return EntityClass::Manakopter;
    //    case 0xc59d10: return EntityClass::Deco;
    //    case 0xc59e4c: return EntityClass::Hive;
    //    case 0xc59ec8: return EntityClass::Mushroom;
    //    case 0xc59f44: return EntityClass::Plant;
    //    case 0xc59fc0: return EntityClass::ShadowHerb;
    //    case 0xc5cde8: return EntityClass::Stone;
    //    case 0xc5ce68: return EntityClass::Tree;
    //    default: return EntityClass::Unknown;
    //    }
    //}

    //inline void clrSelectionVisibility() { selectionFlags &= 0b11111001; }
    //inline void setSelectionVisibility() { selectionFlags |= 0b00000110; } // there can be max 100 settlers that have visible selection markers!
    //inline BYTE getTribe() { return tribe & 0xF; } // 0 == roman, 1 == viking 2 == maya, 3 == darktribe, 4 == troyan
    //inline bool isTribe() { return tribe & 10; } // return true if this object is a tribe object 
};
struct IAnimatedEntity : public IEntity {
    /* +36 S */ BYTE unk6;
    /* +37 S */ BYTE unk7;
    /* +38 S */ WORD unk8;
    /* +40 S */ WORD unk9;
    /* +42 S */ WORD unk10;
    /* +44 S */ DWORD unk11;
    /* +48 S */ DWORD unk12;
    /* +52 s */ INT unk13;
    /* +56 s */ INT unk14;

    virtual VOID vfunc25() = 0;
    virtual VOID vfunc26() = 0;
    virtual VOID vfunc27(DWORD) = 0;
};
struct IMovingEntity : public IAnimatedEntity {
    /* +60 S */ DWORD unk15;
    /* +64 S */ CHAR unk16;
    /* +65 S */ BYTE unk17;
    /* +66 S */ BYTE unk18;
    /* +67 _ */ BYTE pad2;
    /* +68 _ */ WORD unk19;
    /* +70 _ */ WORD unk20;
    /* +72 S */ DWORD unk21;
    /* +76 s */ DWORD unk22;
    /* +80 _ */ LPVOID unk23;
    /* +84 _ */ DWORD unk24;
    virtual VOID vfunc28(LPVOID, WORD) = 0;
    virtual BYTE vfunc29() = 0;
};
struct CAnimal : public IMovingEntity {
    /* +88 S */ WORD unk25;
    /* +90 _ */ BYTE unk26[14];
    /* +104 S */ BYTE unk27;
    /* +105 S */ BYTE unk28;
    /* +106 S */ BYTE unk29;
    /* +107 S */ BYTE unk30;
    /* +108 S */ BYTE unk31;
    /* +109 S */ BYTE unk32;
    /* +110 _ */ WORD pad3;
    /* +112 S */ DWORD unk33;
    /* +116 _ */ DWORD unk34;
    /* +120 S */ DWORD unk35;

    virtual VOID vfunc30() = 0;
    virtual DWORD vfunc31() = 0; // todo:
    virtual VOID vfunc32(CHAR) = 0; // this is probably the default state machine for animals
};
struct CSettler : public IMovingEntity {
    /* +88 _ */ ISettlerRole* role; // the settler role object

    virtual DWORD onUpdate() = 0; // this will dispatch the call to the onUdate of the role object
};
struct CLandAnimal : public CAnimal {
    /* +124 S */ DWORD unk_7c;
    /* +128 S */ DWORD unk_80;
    /* +132 S */ DWORD unk_84;
    /* +136 S */ DWORD unk_88;
    /* +140 S */ DWORD unk_8c;
    /* +144 S */ DWORD unk_90;
    /* +148 S */ DWORD unk_94;
    /* +152 S */ DWORD unk_98;
    /* +156 S */ DWORD unk_9c;
};
struct CBuilding : public IAnimatedEntity {
    /* +60 _ */ DWORD unk_3c;
    /* +64 S */ BYTE unk_40;
    /* +65 S */ BYTE pad_41;
    /* +66 S */ WORD unk_42;
    /* +68 S */ DWORD unk_44;
    /* +72 S */ DWORD unk_48;
    /* +76 S */ DWORD unk_4c;
    /* +80 S */ IBuildingRole* role;
    /* +84 s */ DWORD unk_54;
    /* +88 S */ DWORD unk_58;

    virtual VOID vfunc28() = 0;
    virtual VOID vfunc29(DWORD) = 0;
    virtual VOID vfunc30(DWORD, DWORD**) = 0;
    virtual VOID vfunc31(DWORD) = 0;
};
struct CPile : public IAnimatedEntity {
    /* +60 _ */ DWORD unk_3c;
    /* +64 S */ GoodType goodType;
    /* +65 S */ BYTE amount;
    /* +66 S */ BYTE unk_42;
    /* +67 S */ BYTE unk_43;
    /* +68 S */ BYTE unk_44;
    /* +69 S */ BYTE unk_45;
    /* +70 S */ BYTE unk_46;
    /* +71 _ */ BYTE pad_47;
    /* +72 S */ WORD unk_48;
    /* +74 S */ WORD unk_4a;
    /* +76 S */ CHAR unk_4c;
    /* +77 _ */ BYTE pad_4d;
    /* +78 S */ WORD unk_4e;
    /* +80 S */ IPileRole* role;
    /* +84 S */ LPVOID unk_54;

    virtual VOID vfunc28(DWORD) = 0;
};
struct IDecoObject : public IAnimatedEntity {
    /* +60 _ */ DWORD unk_3c;
    /* +64 S */ DWORD unk_40;

    virtual DWORD vfunc28(CHAR) = 0;
    virtual BYTE vfunc29() = 0;
};
struct IFlyingEntity : public IAnimatedEntity {
    /* +60 _ */ DWORD unk_3c;
    /* +64 S */ DWORD unk_40;
    /* +68 S */ DWORD unk_44;
    /* +72 S */ WORD unk_48;
    /* +74 S */ WORD unk_4a;
    /* +76 S */ WORD unk_4c;
    /* +78 S */ CHAR unk_4e;
    /* +78 _ */ BYTE pad_4f;
    /* +80 s */ LPVOID unk_50;
    /* +84 S */ INT32 unk_54;

    virtual VOID vfunc28(DWORD) = 0;
    virtual VOID vfunc29(DWORD) = 0;
    virtual VOID vfunc30() = 0;
};
struct CDecoObject : public IDecoObject {
    /* +68 S */ CHAR unk_44;
    /* +69 S */ CHAR unk_45;
    /* +70 S */ BYTE unk_46;
    /* +71 _ */ BYTE pad_47;
    /* +72 S */ WORD unk_48;
    /* +74 _ */ WORD pad_4a;
};
struct CHive : public IDecoObject {/* todo: fill struct */ };
struct CMushroom : public IDecoObject {/* todo: fill struct */ };
struct CPlant : public IDecoObject {/* todo: fill struct */ };
struct CShadowHerb : public IDecoObject {/* todo: fill struct */ };
struct CStone : public IDecoObject {
    virtual VOID vfunc30() = 0;
};
struct CTree : public IDecoObject {
    /* +68 S */ CHAR unk_44;
    /* +69 S */ BYTE unk_45;
    /* +70 S */ BYTE unk_46;
    /* +71 _ */ BYTE pad_47;
    /* +72 S */ DWORD unk_48;
};
