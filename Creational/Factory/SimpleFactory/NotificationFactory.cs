using Creational.Factory.SimpleFactory.Enums;
using Creational.Factory.SimpleFactory.Interfaces;
using Creational.Factory.SimpleFactory.Models;

namespace Creational.Factory.SimpleFactory
{
    internal static class NotificationFactory
    {
        internal static INotification Create(NotificationType type)
        {
            return type switch
            {
                NotificationType.Email => new EmailNotification(),
                NotificationType.Sms => new SmsNotification(),
                NotificationType.Push => new PushNotification(),
                _ => throw new ArgumentException("Invalid notification type")
            };
        }
    }
}
