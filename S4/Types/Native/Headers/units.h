#pragma once

#include "entities.h"

struct CVehicle : public IMovingEntity {
    /* +88 _ */ LPVOID unk25;
    /* +92 S */ BYTE unk26;
    /* +93 S */ BYTE unk27;
    /* +94 S */ BYTE unk28;
    /* +95 S */ BYTE unk29;
    /* +96 S */ BYTE unk30;
    /* +97 S */ BYTE unk31;
    /* +98 S */ BYTE unk32;
    /* +99 S */ BYTE unk33;
    /* +100 S */ BYTE unk34;
    /* +101 S */ BYTE unk35;
    /* +102 S */ WORD unk36;
    /* +104 S */ DWORD unk37;
    /* +108 S */ BYTE unk38;
    /* +109 S */ BYTE unk39;
    /* +110 S */ BYTE unk40;
    /* +111 S */ BYTE unk41;
    /* +112 S */ WORD unk42;
    /* +114 S */ WORD unk43;
    /* +116 S */ WORD unk44;
    /* +118 S */ WORD unk45;
    /* +120 S */ WORD unk46;
    /* +122 _ */ BYTE unk47[6];
    /* +128 s */ INT32 unk48;
    /* +132 s */ INT32 unk49;
    /* +136 _ */ DWORD unk50;
    /* +140 _ */ DWORD unk51;
    /* +144 _ */ DWORD unk52;

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
    /* +148 S */ DWORD unk53;
    /* +152 S */ DWORD unk54;
    /* +156 S */ DWORD unk55;

    virtual VOID vfunc55() = 0;
    virtual VOID vfunc56(INT) = 0;
};
class CShip : public CVehicle {
    /* +148 S */ DWORD unk53;
};
struct CCart : public CWheeler {
    /* +160 s */ INT32 unk56;
    /* +164 s */ INT32 unk57;
    /* +168 _ */ DWORD unk58;
    /* +172 s */ INT unk59;
    /* +176 s */ INT unk60;
    /* +180 _ */ DWORD unk61;
    /* +184 S */ BYTE unk62;
    /* +185 S */ BYTE unk63;
    /* +186 S */ BYTE unk64;
    /* +187 S */ BYTE unk65;
    /* +188 S */ CHAR unk66;
    /* +189 S */ CHAR unk67;
    /* +190 S */ BYTE unk68;
    /* +191 S */ BYTE unk69;
    /* +192 _ */ DWORD unk70;
    /* +196 S */ DWORD unk71;
    /* +200 s */ DWORD unk72[18]; // probably a byte array or some object
    /* +272 S */ CHAR unk73;
    /* +273 S */ CHAR unk74;
    /* +274 S */ CHAR unk75;
    /* +275 _ */ BYTE unk76; // probably pad
    /* +276 S */ DWORD unk77;
    /* +280 S */ DWORD unk78;
    /* +284 S */ DWORD unk79;
    /* +288 S */ DWORD unk80;
    /* +292 S */ BYTE unk81;
    /* +293 S */ CHAR unk82;
    /* +294 S */ WORD pad4;

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
    /* +160 _ */ DWORD unk56[6];
    /* +184 S */ CHAR unk57;
    /* +185 _ */ BYTE pad5[3];
    /* +188 S */ DWORD unk58;
    /* +192 S */ DWORD unk59;

    virtual DWORD vfunc57() = 0; // always returns 4. todo: verify whether this gets added to the CWheeler vtable
};
struct CWarShip : public CShip, public CWarriorBehaviour {
    /* +152 _ */ DWORD unk54;
    /* +156 _ */ DWORD unk55;
    /* +160 _ */ DWORD unk56;
    /* +164 S */ DWORD unk57;
    /* +168 S */ DWORD unk58;

    virtual DWORD vfunc55() = 0; // always returns 4. todo: verify whether this gets added to the CWheeler vtable
};
struct CFerryShip : public CShip {
    /* +152 _ */ DWORD unk54;
    /* +156 s */ DWORD unk55;
    /* +160 s */ DWORD unk56;
    /* +164 s */ DWORD unk57;
    /* +168 s */ DWORD unk58;
    /* +172 s */ DWORD unk59;
    /* +176 s */ DWORD unk60;
    /* +180 s */ DWORD unk61;
    /* +184 s */ DWORD unk62;
    /* +188 s */ DWORD unk63;
};
struct CTransportShip : public CShip {
    /* +152 S */ DWORD unk54[31];
    /* +276 S */ BYTE unk55;
    /* +277 S */ BYTE pad56[3];
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