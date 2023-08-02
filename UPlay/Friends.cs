using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Forge.UX.Native;

// ReSharper disable FieldCanBeMadeReadOnly.Local
// ReSharper disable MemberCanBePrivate.Local
#pragma warning disable CS8500

namespace Forge.UX.UPlay {
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

        // Filter -> 1 = "request_sent"; 2 = "request_received"; 4 = "friends"; 8 = "blacklisted"; 0xFF = "all
        private unsafe delegate bool _UPlayFriendsGetFriendList(uint filter, UPlayFriendList* list);
        private unsafe delegate bool _UPlayFriendsInviteToGame(IntPtr accountId, InviteParameters* param);

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

                bool result = UPlayFriendsGetFriendList(4, &friendList);
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
                var inviteParams = new InviteParameters() { unknownProbablySize = 15 }; //don't ask why
                UPlayFriendsInviteToGame(Marshal.StringToHGlobalAnsi(friend.AccountId), &inviteParams);
            }
        }
    }

    public struct Friend {
        public string PlayerName { get; }
        public string AccountId { get; }
        public bool IsOnline { get; } //Not Yet Implemented - Does not exists in the UPLAY_FRIENDS API - maybe with a different API?

        public Friend(string playerName, string accountId, bool isOnline) {
            this.PlayerName = playerName;
            this.AccountId = accountId;
            this.IsOnline = isOnline;
        }
    }
}
