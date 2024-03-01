using DryIoc;

using Forge.Config;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Notifications {
    public class NotificationsService {
        public delegate void NotificationHandler(INotification notification);

        public event NotificationHandler? OnNotification;

        private readonly List<INotification> notifications = new List<INotification>();

        public void Notify(INotification notification) {
            notification.Timestamp = (int)DateTimeOffset.Now.ToUnixTimeSeconds();

            notifications.Add(notification);
            OnNotification?.Invoke(notification);
        }

        public void ClearNotifications() {
            notifications.Clear();
        }

        public List<INotification> GetNotifications() {
            return notifications;
        }

        public static void RegisterDependencies() {
            DI.Dependencies.Register<NotificationsService>(Reuse.Singleton);
        }
    }
}
