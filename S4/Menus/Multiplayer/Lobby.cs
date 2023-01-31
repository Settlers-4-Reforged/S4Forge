using S4_UIEngine.UI.Elements.Grouping;
using S4_UIEngine.UI.Elements.Grouping.Display;
using S4_UIEngine.UI.Elements.Interaction;
using S4_UIEngine.UI.Elements.Static;
using S4_UIEngine.UPlay;
using System.Numerics;

namespace S4_UIEngine.S4.Menus.Multiplayer {
    // Multiplayer Lobby related fixes/additions
    internal class Lobby {
        private static readonly UIWindow inviteWindow = UIWindow.Create(); //TODO: add texture

        public static void OnInviteClick() {
            Friend[] friends = Friends.GetFriends();

            inviteWindow.Size = new Vector2(175, 800);
            UIRows rows = new UIRows(16);

            inviteWindow.Elements.Add(rows);

            foreach (Friend friend in friends) {
                UIGroup row = new UIGroup();
                S4Button inviteButton = new S4Button {
                    Text = "Invite",
                    OnPress = _ => Friends.InviteFriend(friend),
                    Position = new Vector2(100, 0)
                };

                UIText playerName = new UIText(friend.PlayerName);


                row.Elements.Add(inviteButton);
                row.Elements.Add(playerName);

                rows.AddRow(row);
            }

            inviteWindow.Open();
        }
    }
}
