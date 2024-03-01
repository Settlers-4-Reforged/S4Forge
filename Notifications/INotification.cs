using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Notifications {
    public interface INotification {
        /// <summary>
        /// Where the notification came from. Can be a class name, a method name, or any other string.
        /// </summary>
        /// <remarks>
        /// This is mainly for debugging and tracing purposes, but may be used by other plugins differently.
        /// </remarks>
        public string Source { get; }

        /// <summary>
        /// A list of tags that can be used to filter notifications.
        /// </summary>
        /// <remarks>
        /// Example being:<br/>
        /// - A notification from a chat system may have the tags "chat", "message", and "user".
        /// - Error notifications may have the tags "error", "exception", or "critical": Those are e.g. used by the UI notifications.
        /// </remarks>
        public string[] Tags { get; }

        /// <summary>
        /// When the notification was created.
        /// </summary>
        /// <remarks>
        /// This value is set by the <see cref="NotificationsService"/> when the notification is sent.
        /// </remarks>
        public int Timestamp { get; set; }
    }
}
