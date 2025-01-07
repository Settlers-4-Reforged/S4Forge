#pragma once

#include "entities.h"

struct CVehicle : public IMovingEntity {
    /* +88 _ */ LPVOID unk_58;
    /* +92 S */ BYTE unk_5c;
    /* +93 S */ BYTE unk_5d;
    /* +94 S */ BYTE unk_5e;
    /* +95 S */ BYTE unk_5f;
    /* +96 S */ BYTE unk_60;
    /* +97 S */ BYTE unk_61;
    /* +98 S */ BYTE unk_62;
    /* +99 S */ BYTE unk_63;
    /* +100 S */ BYTE unk_64;
    /* +101 S */ BYTE unk_65;
    /* +102 S */ WORD unk_66;
    /* +104 S */ DWORD unk_68;
    /* +108 S */ BYTE unk_6c;
    /* +109 S */ BYTE unk_6d;
    /* +110 S */ BYTE unk_6e;
    /* +111 S */ BYTE unk_6f;
    /* +112 S */ WORD unk_70;
    /* +114 S */ WORD unk_72;
    /* +116 S */ WORD unk_74;
    /* +118 S */ WORD unk_76;
    /* +120 S */ WORD unk_78;
    /* +122 _ */ BYTE unk_7a[6];
    /* +128 s */ INT32 unk_80;
    /* +132 s */ INT32 unk_84;
    /* +136 _ */ DWORD unk_88;
    /* +140 _ */ DWORD unk_8c;
    /* +144 _ */ DWORD unk_90;


    virtual VOID vfunc30() = 0;
    virtual VOID vfunc31() = 0;
    virtual VOID vfunc32() = 0;
    virtual VOID vfunc33() = 0;
    virtual VOID vfunc34() = 0;
    virtual DWORD vfunc35() = 0; // returns unk4 from +24
    virtual VOID vfunc36() = 0;
    virtual VOID vfunc37() = 0;
    virtual VOID vfunc38() = 0;
    virtual VOID vfunc39(INT) = 0;
    virtual VOID vfunc40() = 0;
    virtual VOID vfunc41(DWORD) = 0;
    virtual VOID vfunc42(DWORD) = 0;
    virtual VOID vfunc43() = 0; // sets bit 0x20 at selectionFlags +21 
    virtual VOID vfunc44() = 0; // clears bit 0x20 at selectionFlags +21 
    virtual VOID vfunc45() = 0;
    virtual VOID vfunc46() = 0;
    virtual VOID vfunc47() = 0;
    virtual VOID vfunc48() = 0;
    virtual VOID vfunc49(DWORD) = 0;
    virtual VOID vfunc50(DWORD) = 0;
    virtual BYTE vfunc51() = 0; // is a bool that returns true if unk33 at +99 is non-zero
    virtual DWORD vfunc52() = 0; // getter for byte at +99
    virtual VOID vfunc53() = 0; // decrements byte at +99 if non-zero
    virtual VOID vfunc54(DWORD) = 0;
};
struct CWheeler : public CVehicle {
    /* +148 S */ DWORD unk_94;
    /* +152 S */ DWORD unk_98;
    /* +156 S */ DWORD unk_9c;

    virtual VOID vfunc55() = 0;
    virtual VOID vfunc56(INT) = 0;
};
class CShip : public CVehicle {
    /* +148 S */ DWORD unk_94;
};
struct CCart : public CWheeler {
    /* +160 s */ INT32 unk_a0;
    /* +164 s */ INT32 unk_a4;
    /* +168 _ */ DWORD unk_a8;
    /* +172 s */ INT unk_ac;
    /* +176 s */ INT unk_b0;
    /* +180 _ */ DWORD unk_b4;
    /* +184 S */ BYTE unk_b8;
    /* +185 S */ BYTE unk_b9;
    /* +186 S */ BYTE unk_ba;
    /* +187 S */ BYTE unk_bb;
    /* +188 S */ CHAR unk_bc;
    /* +189 S */ CHAR unk_bd;
    /* +190 S */ BYTE unk_be;
    /* +191 S */ BYTE unk_bf;
    /* +192 _ */ DWORD unk_c0;
    /* +196 S */ DWORD unk_c4;
    /* +200 s */ DWORD unk_c8[18]; // probably a byte array or some object
    /* +272 S */ CHAR unk_110;
    /* +273 S */ CHAR unk_111;
    /* +274 S */ CHAR unk_112;
    /* +275 _ */ BYTE unk_113; // probably pad
    /* +276 S */ DWORD unk_114;
    /* +280 S */ DWORD unk_118;
    /* +284 S */ DWORD unk_11c;
    /* +288 S */ DWORD unk_120;
    /* +292 S */ BYTE unk_124;
    /* +293 S */ CHAR unk_125;
    /* +294 S */ WORD pad_126;

    virtual INT vfunc57() = 0; // todo: verify whether this gets added to the CWheeler vtable
};
struct CWarriorBehaviour {
    virtual VOID warriorfunc0(INT, LPVOID, DWORD) = 0;
    virtual DWORD warriorfunc1() = 0;
    virtual DWORD warriorfunc2() = 0; // this accesses the map
    virtual VOID warriorfunc3(LPVOID, INT) = 0; // used to register for logic updates. Maybe starts a state machine?
    virtual VOID warriorfunc4() = 0;
};
struct CCatapult : public CWheeler, public CWarriorBehaviour {
    /* +160 _ */ DWORD unk_a0[6];
    /* +184 S */ CHAR unk_b8;
    /* +185 _ */ BYTE pad_b9[3];
    /* +188 S */ DWORD unk_bc;
    /* +192 S */ DWORD unk_c0;

    virtual DWORD vfunc57() = 0; // always returns 4. todo: verify whether this gets added to the CWheeler vtable
};
struct CWarShip : public CShip, public CWarriorBehaviour {
    /* +152 _ */ DWORD unk_98;
    /* +156 _ */ DWORD unk_9c;
    /* +160 _ */ DWORD unk_a0;
    /* +164 S */ DWORD unk_a4;
    /* +168 S */ DWORD unk_a8;

    virtual DWORD vfunc55() = 0; // always returns 4. todo: verify whether this gets added to the CWheeler vtable
};
struct CFerryShip : public CShip {
    /* +152 _ */ DWORD unk_98;
    /* +156 s */ DWORD unk_9c;
    /* +160 s */ DWORD unk_a0;
    /* +164 s */ DWORD unk_a4;
    /* +168 s */ DWORD unk_a8;
    /* +172 s */ DWORD unk_ac;
    /* +176 s */ DWORD unk_b0;
    /* +180 s */ DWORD unk_b4;
    /* +184 s */ DWORD unk_b8;
    /* +188 s */ DWORD unk_bc;
};
struct CTransportShip : public CShip {
    /* +152 S */ DWORD unk_98[31];
    /* +276 S */ BYTE unk_114;
    /* +277 S */ BYTE pad_115[3];
};
struct CMayaCatapult : public CCatapult {/* todo: fill struct */ };
struct CRomanCatapult : public CCatapult {/* todo: fill struct */ };
struct CTrojanCatapult : public CCatapult {/* todo: fill struct */ };
struct CVikingCatapult : public CCatapult {/* todo: fill struct */ };
struct CMayaWarShip : public CWarShip {/* todo: fill struct */ };
struct CRomanWarShip : public CWarShip {/* todo: fill struct */ };
struct CTrojanWarShip : public CWarShip {/* todo: fill struct */ };
struct CVikingWarShip : public CWarShip {/* todo: fill struct */ };
struct CManakopter : public IFlyingEntity {/* todo: fill struct */ };