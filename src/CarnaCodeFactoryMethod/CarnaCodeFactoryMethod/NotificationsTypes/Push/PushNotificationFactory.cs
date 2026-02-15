using CarnaCodeFactoryMethod.Abstractions;

namespace CarnaCodeFactoryMethod.NotificationsTypes.Push;

public sealed class PushNotificationFactory(string title) : NotificationFactory
{
    public override INotificationType CreateNotification(string recipient, string message) => 
        new PushNotificationType(recipient, message, title);
    
}