using CarnaCodeFactoryMethod.Abstractions;

namespace CarnaCodeFactoryMethod.NotificationsTypes.Sms;

public sealed class SmsNotificationFactory : NotificationFactory
{
    public override INotificationType CreateNotification(string recipient, string message) =>
        new SmsNotificationType(recipient, message);
}