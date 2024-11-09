#pragma once

#include "enums.h"

// Settlers 4 Entities
// fields marked with capital S are serialized, a lower case s means that they are serialized but are specially encoded
#pragma pack(1)
struct CPersistance {
	virtual LPVOID vfunc0() = 0; // returns some static value. Has probably something to do with serialization or rtti
	virtual VOID serialize(DWORD *) = 0;
};

/*
    inline LPVOID* GetVtable() { return (void**)this; }
	PersistentRole GetRoleClass() {
		// todo: the following offsets work only for version with md5 c13883cbd796c614365ab2d670ead561
		switch ((DWORD)GetVtable() - S4_Main) {
			// Pile Roles
		case 0xc5a66c: return PersistentRole::PileAnywhere;
		case 0xc5a714: return PersistentRole::PileBuildingSite;
		case 0xc5a768: return PersistentRole::PileDelivery;
		case 0xc5a8fc: return PersistentRole::PileProduction;
		case 0xc5a8a8: return PersistentRole::PileStorage;
		case 0xc5a950: return PersistentRole::PileTrade;

			// Building Roles
		case 0xc58e84: return PersistentRole::BuildingWorkup;  // needs confirmation
		case 0xc5837c: return PersistentRole::BuildingAnimalranch;
		case 0xc58f8c: return PersistentRole::BuildingMilitary; // needs confirmation
		case 0xc58c74: return PersistentRole::BuildingCastle;
		case 0xc5958c: return PersistentRole::BuildingTrading;
		case 0xc58484: return PersistentRole::BuildingBarrack;
		case 0xc58508: return PersistentRole::BuildingBigtemple;
		case 0xc591bc: return PersistentRole::BuildingSite;
		case 0xc58ae8: return PersistentRole::BuildingMushroomfarm;
		case 0xc59284: return PersistentRole::BuildingDarktemple;
		case 0xc58b6c: return PersistentRole::BuildingEyecatcher;
		case 0xc58cf8: return PersistentRole::BuildingFarm;
		case 0xc58f08: return PersistentRole::BuildingGather;
		case 0xc58d7c: return PersistentRole::BuildingLookouttower;
		case 0xc593d0: return PersistentRole::BuildingManakopterhall;
		case 0xc59484: return PersistentRole::BuildingMine;
		case 0xc59094: return PersistentRole::BuildingProduction;
		case 0xc59010: return PersistentRole::BuildingResidence;
		case 0xc58e00: return PersistentRole::BuildingSimple;
		case 0xc58bf0: return PersistentRole::BuildingSmalltemple;
		case 0xc59508: return PersistentRole::BuildingStorage;
		case 0xc59610: return PersistentRole::BuildingWorkshop;

			// Settler Roles
		case 0xc5a9d8: return PersistentRole::SettlerBuilder;
		case 0xc5ab08: return PersistentRole::SettlerCarrier;
		case 0xc5ad04: return PersistentRole::SettlerDarkgardener;
		case 0xc5ad8c: return PersistentRole::SettlerDigger;
		case 0xc5ae90: return PersistentRole::SettlerDonkey;
		case 0xc5af38: return PersistentRole::SettlerDoor;
		case 0xc5afc0: return PersistentRole::SettlerFlee;
		case 0xc5b2cc: return PersistentRole::SettlerFreeworker;
		case 0xc5b8b0: return PersistentRole::SettlerHouseworker;
		case 0xc5bb18: return PersistentRole::SettlerHunter;
		case 0xc5bbf8: return PersistentRole::SettlerMushroomfarmer;
		case 0xc5c254: return PersistentRole::SettlerSlave;
		case 0xc5c584: return PersistentRole::SettlerTowersoldier;

			// The following are selectables
		case 0xc5b51c: return PersistentRole::SettlerGardener;
		case 0xc5b5f8: return PersistentRole::SettlerGeologist;
		case 0xc5bc94: return PersistentRole::SettlerPioneer;
		case 0xc5bd1c: return PersistentRole::SettlerPriest;
		case 0xc5c4b4: return PersistentRole::SettlerThief;

			// The following roles have a WarriorBehaviour attached. Note that 
			// war machines/ships do not have a role but inherit directly from WarriorBehaviour!
		case 0xc5c3ac: return PersistentRole::SettlerSoldier;
		case 0xc5b7f0: return PersistentRole::SettlerSquadleader;  // needs confirmation
		case 0xc5b734: return PersistentRole::SettlerHjb;  // needs confirmation
		case 0xc5c14c: return PersistentRole::SettlerShaman;
		case 0xc5bdbc: return PersistentRole::SettlerSaboteur;
		default: return PersistentRole::Unknown;
		};
	}
*/