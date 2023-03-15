using System.Numerics;
using S4UI.UI.Elements.Grouping;
using S4UI.UI.Elements.Grouping.Display;
using S4UI.UI.Elements.Interaction;
using S4UI.UI.Elements.Static;
using S4UI.UPlay;

namespace S4UI.S4.Menus.Multiplayer {
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
