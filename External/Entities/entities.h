#pragma once

#include "../s4.h"

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

    virtual ISettlerRole* vfunc2(BYTE);
    virtual DWORD vfunc3(); // todo: type me
    virtual void walk(LPVOID); // this may also check the landscape to adjust the walk speed, it will also register for logic update
    virtual DWORD vfunc5(); // todo: type me
    virtual void vfunc6(LPVOID); // may call register logic update
    virtual DWORD vfunc7(); // todo: type me
    virtual void vfunc8();
    virtual DWORD vfunc9(); // todo: type me
    virtual DWORD vfunc10(); // todo: type me
    virtual DWORD vfunc11(); // todo: type me
    virtual void vfunc12(WORD); // setter for unk_20
    virtual void vfunc13(WORD); // setter for unk_22
    virtual DWORD vfunc14(); // todo: type me
    virtual DWORD vfunc15(INT); // this accesses a map
    virtual DWORD vfunc16(INT*);
    virtual DWORD vfunc17(DWORD); // may return the only param
    virtual DWORD vfunc18(); // todo: type me
    virtual BYTE vfunc19(); // may return 0
    virtual void vfunc20(INT, WORD); // setter for unk_20 and unk_14
    virtual DWORD vfunc21(INT); // getter for unk_20 and unk_14
    virtual DWORD vfunc22(); // may return 0
    virtual DWORD vfunc23(); // may return 0
    virtual DWORD vfunc24(); // may return 0
    virtual DWORD vfunc25(); // may return 0
    virtual DWORD vfunc26(); // may return 0
    virtual DWORD vfunc27(); // may return 1
    virtual DWORD vfunc28(); // may return 0
    virtual BYTE vfunc29();  // may return 0
    virtual DWORD vfunc30(INT, INT); // accesses the map
    virtual BYTE vfunc31(LPVOID);
    virtual void vfunc32(INT, INT**, WORD, WORD, DWORD);
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
    /* +11 _ */ BYTE pad_b; // unused alignment byte (?)
    /* +12 S */ WORD objectId; // this is the settler/building id etc
    /* +14 _ */ BYTE unk_e;
    /* +15 _ */ BYTE unk_f;
    /* +16 _ */ DWORD unk_10;
    /* +20 S */
    enum BaseType : BYTE {
        Civilian, // civilian building or object like wheat plant etc (wheatplant has settlerType == 209 and goodtype == 0)
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
    /* +22 S */ BYTE unk_16;
    /* +23 S */ BYTE unk_17;
    /* +24 S */ WORD x;
    /* +26 S */ WORD y;
    /* +28 _ */ BYTE unk_1c; // looks like set to be to the nearest entity id (but only selectively)
    /* +29 _ */ BYTE unk_1d;
    /* +30 _ */ WORD unk_1e;
    /* +32 S */ struct {
        BYTE tribe : 4; // only the 4 most significant bits are the player, todo: confirm it
        BYTE player : 4; // only the 4 least significant bits are the tribe
#pragma warning(suppress: 4201) // suppress unnamed structures
    };
    /* +33 S */ BYTE health;
    /* +34 _ */ BYTE pad_22;
    /* +35 _ */ BYTE pad_23;

    virtual IEntity* vfunc2(LPVOID); // probably some kind of destroy/dispose method
    virtual DWORD vfunc3();
    virtual void vfunc4(); // something with map access
    virtual LPVOID PopulateRenderData(); // Populates the render data object with the current state of the entity
    virtual DWORD Heal(DWORD health); 
    virtual void DamageBy(DWORD damage, DWORD attackingEntityId);
    virtual void Damage(DWORD damage);
    virtual void vfunc9();
    virtual DWORD GetHealth(); // simple getter for buildings
    virtual DWORD vfunc11(); // returns always 0 for buildings
    virtual void vfunc12(); // does nothing for buildings
    virtual void vfunc13(INT);
    virtual void vfunc14();
    virtual DWORD vfunc15();  // returns always 0 for buildings
    virtual DWORD vfunc16();  // returns always 0 for buildings
    virtual void vfunc17(INT, INT);
    virtual DWORD vfunc18(INT);
    virtual void vfunc19();
    virtual void vfunc20(DWORD);
    virtual DWORD vfunc21();  // returns always 0 for buildings
    virtual DWORD vfunc22();  // returns always 0 for buildings
    virtual DWORD vfunc23();  // returns always 0 for buildings
    virtual DWORD vfunc24();  // returns always 0 for buildings
};
struct IAnimatedEntity : public IEntity {
    /* +36 S */ BYTE animationFrameIndex; // Seems to be the current frame of the animation
    /* +37 S */ BYTE unk_25;
    /* +38 S */ WORD unk_26; // Looks like JIL id (but only for settlers?)
    /* +40 S */ WORD nextEntity; // Seems to be a double linked list id entry for the next of the same type?
    /* +42 S */ WORD prevEntity; // ^^ but with the previous entry
    /* +44 S */ DWORD globalTick; // Global tick counter
    /* +48 S */ DWORD unk_30;
    /* +52 s */ INT unk_34; // Points to a CEntityEvent
    /* +56 s */ INT unk_38; // Points to a CEntityEvent

    virtual void vfunc25();
    virtual void vfunc26();
    virtual void vfunc27(DWORD);
};
struct IMovingEntity : public IAnimatedEntity {
    /* +60 S */ DWORD unk_3c;
    /* +64 S */ CHAR unk_40;
    /* +65 S */ BYTE unk_41;
    /* +66 S */ BYTE unk_42;
    /* +67 _ */ BYTE pad_43;
    /* +68 _ */ WORD unk_44;
    /* +70 _ */ WORD unk_46;
    /* +72 S */ DWORD unk_48;
    /* +76 s */ DWORD unk_4c;
    /* +80 _ */ LPVOID unk_50;
    /* +84 _ */ DWORD unk_54;
    virtual void vfunc28(LPVOID, WORD);
    virtual BYTE vfunc29();
};
struct CAnimal : public IMovingEntity {
    /* +88 S */ WORD unk_58;
    /* +90 _ */ BYTE unk_5a[14];
    /* +104 S */ BYTE unk_68;
    /* +105 S */ BYTE unk_69;
    /* +106 S */ BYTE unk_6a;
    /* +107 S */ BYTE unk_6b;
    /* +108 S */ BYTE unk_6c;
    /* +109 S */ BYTE unk_6d;
    /* +110 _ */ WORD pad_6e;
    /* +112 S */ DWORD unk_70;
    /* +116 _ */ DWORD unk_74;
    /* +120 S */ DWORD unk_78;

    virtual void vfunc30();
    virtual DWORD vfunc31(); // todo:
    virtual void vfunc32(CHAR); // this is probably the default state machine for animals
};
struct CSettler : public IMovingEntity {
    /* +88 _ */ ISettlerRole* role; // the settler role object

    virtual DWORD onUpdate(); // this will dispatch the call to the onUdate of the role object
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

    virtual void vfunc28();
    virtual void vfunc29(DWORD);
    virtual void vfunc30(DWORD, DWORD**);
    virtual void vfunc31(DWORD);
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

    virtual void vfunc28(DWORD);
};
struct IDecoObject : public IAnimatedEntity {
    /* +60 _ */ DWORD unk_3c;
    /* +64 S */ DWORD unk_40;

    virtual DWORD vfunc28(CHAR);
    virtual BYTE vfunc29();
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

    virtual void vfunc28(DWORD);
    virtual void vfunc29(DWORD);
    virtual void vfunc30();
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
    virtual void vfunc30();
};
struct CTree : public IDecoObject {
    /* +68 S */ CHAR unk_44;
    /* +69 S */ BYTE unk_45;
    /* +70 S */ BYTE unk_46;
    /* +71 _ */ BYTE pad_47;
    /* +72 S */ DWORD unk_48;
};
