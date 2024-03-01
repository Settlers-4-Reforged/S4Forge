using DryIoc;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Notifications {

    /// <summary>
    /// A simple text notification used by the Notification plugin to display messages to the user.
    /// </summary>
    [DebuggerDisplay("Text: {Text} @ {MessageType} from {Source}")]
    public sealed class TextNotification : INotification {
        public string Source { get; init; }

        /// <summary>
        /// The default tag for text notifications.
        /// </summary>
        public const string TextNotificationTag = "text";

        private string[]? tags = null;
        public string[] Tags {
            get {
                // Cache the tags
                return tags ??= new string[] { TextNotificationTag, MessageType.ToString() };
            }
        }

        public int Timestamp { get; set; }

        public string Text { get; init; }

        public Type MessageType { get; init; }

        public enum Type {
            Info,
            Warning,
            Error
        }

        public TextNotification(string source, string message, Type type = Type.Info) {
            Source = source;
            Text = message;
            MessageType = type;
        }

        public static TextNotification Error(string source, string message) {
            return new TextNotification(source, message, Type.Error);
        }

        public static TextNotification Warning(string source, string message) {
            return new TextNotification(source, message, Type.Warning);
        }

        public static TextNotification Info(string source, string message) {
            return new TextNotification(source, message, Type.Info);
        }
    }
}
