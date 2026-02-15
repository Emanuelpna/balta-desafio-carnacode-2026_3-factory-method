using CarnaCodeFactoryMethod.Abstractions;

namespace CarnaCodeFactoryMethod.NotificationsTypes.Email;

public sealed class EmailNotificationFactory(string subject, bool isHtml) : NotificationFactory
{
    public override INotificationType CreateNotification(string recipient, string message) =>
        new EmailNotificationType(recipient, subject, message, isHtml);
}