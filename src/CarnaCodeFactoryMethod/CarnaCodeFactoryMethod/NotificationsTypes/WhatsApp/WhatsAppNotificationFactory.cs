using CarnaCodeFactoryMethod.Abstractions;

namespace CarnaCodeFactoryMethod.NotificationsTypes.WhatsApp;

public sealed class WhatsAppNotificationFactory(bool useTemplate) : NotificationFactory
{
    public override INotificationType CreateNotification(string recipient, string message) => new WhatsAppNotificationType(recipient, message, useTemplate);
}