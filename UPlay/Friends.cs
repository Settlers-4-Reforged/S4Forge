using S4_UIEngine.Native;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
// ReSharper disable FieldCanBeMadeReadOnly.Local
// ReSharper disable MemberCanBePrivate.Local
#pragma warning disable CS8500

namespace S4_UIEngine.UPlay {
    public static class Friends {
        [StructLayout(LayoutKind.Sequential, Pack = 0)]
        private struct UPlayFriend {
            public IntPtr accountId;
            public IntPtr name;
            public int relationship;
            public int avatarId;
            public Int32 gameSession;
            public bool blacklisted;
            public Byte unknown1;
            public Byte unknown2;
            public Byte unknown3;
            public IntPtr nickname;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 0)]
        unsafe struct UPlayFriendList {
            public int length;
            public UPlayFriend** friends;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 0)]
        struct InviteParameters {
            public IntPtr __vftable /*VFT*/;
            public Byte unknownA;
            public Byte unknownB;
            public Byte unknownC;
            public Byte unknownD;
            public Int32 unknown2;
            public Int32 unknownLarge1;
            public Int32 unknownLarge2;
            public Int32 unknownLarge3;
            public Int32 unknown3;
            public Int32 unknownLargeB1;
            public Int32 unknownLargeB2;
            public Int32 unknownLargeB3;
            public int unknown4;
            public Int32 unknownProbablySize; //seems to be "15"
        };

        private unsafe delegate bool _UPlayFriendsGetFriendList(uint size/*0xFFu*/, UPlayFriendList* list);
        private unsafe delegate bool _UPlayFriendsInviteToGame(string accountId, InviteParameters* param);

        private static _UPlayFriendsGetFriendList UPlayFriendsGetFriendList;
        private static _UPlayFriendsInviteToGame UPlayFriendsInviteToGame;

        static Friends() {
            IntPtr uplayLib = Kernel32.LoadLibrary("uplay_r1_loader.dll");
            UPlayFriendsGetFriendList = Marshal.GetDelegateForFunctionPointer<_UPlayFriendsGetFriendList>(Kernel32.GetProcAddress(uplayLib, "UPLAY_FRIENDS_GetFriendList"));
            UPlayFriendsInviteToGame = Marshal.GetDelegateForFunctionPointer<_UPlayFriendsInviteToGame>(Kernel32.GetProcAddress(uplayLib, "UPLAY_FRIENDS_InviteToGame"));
        }

        public static Friend[] GetFriends() {
            List<Friend> friends = new List<Friend>();

            unsafe {
                UPlayFriendList friendList = new UPlayFriendList();

                bool result = UPlayFriendsGetFriendList(0xFFu, &friendList);
                Debug.Assert(result);

                if (friendList.friends != null) {
                    for (int i = 0; i < friendList.length; i++) {
                        UPlayFriend* friend = friendList.friends[i];
                        friends.Add(new Friend(Marshal.PtrToStringAnsi(friend->name) ?? "", Marshal.PtrToStringAnsi(friend->accountId) ?? "", false));
                    }
                }
            }

            return friends.ToArray();
        }

        public static void InviteFriend(Friend friend) {
            unsafe {
                var inviteParams = new InviteParameters() { unknownProbablySize = 15 };
                UPlayFriendsInviteToGame(friend.AccountId, &inviteParams);
            }
        }

        /*
         #pragma pack(push, 1)
struct UplayFriend {
		char* accountId;
		char* name;
		int relationship;
		int avatarId;
		DWORD gameSession;
		char blacklisted;
		BYTE unknown[3];
		char* nickname;
};
#pragma pack(pop)

#pragma pack(push, 1)
struct UplayFriendList {
	int length;
	UplayFriend **friends;
};

#pragma pack(pop)
typedef bool(__cdecl* _UPLAY_FRIENDS_GetFriendList)( int, UplayFriendList *);
_UPLAY_FRIENDS_GetFriendList UPLAY_FRIENDS_GetFriendListManaged;

#pragma pack(push, 1)
struct InviteParameters {
	void* __vftable /*VFT;
    BYTE unknown[4];
    DWORD unknown2;
    BYTE unknownLarge[12];
    DWORD unknown3;
    BYTE unknownLarge2[12];
    int unknown4;
    DWORD unknownProbablySize;
};
#pragma pack(pop)

typedef bool (__cdecl* _UPLAY_FRIENDS_InviteToGame) (char*, InviteParameters*);
_UPLAY_FRIENDS_InviteToGame UPLAY_FRIENDS_InviteToGameManaged;
         */
    }

    public struct Friend {
        public string PlayerName { get; }
        public string AccountId { get; }
        public bool IsOnline { get; }

        public Friend(string playerName, string accountId, bool isOnline) {
            this.PlayerName = playerName;
            this.AccountId = accountId;
            this.IsOnline = isOnline;
        }
    }
}
