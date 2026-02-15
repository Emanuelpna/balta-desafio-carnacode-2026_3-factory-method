namespace CarnaCodeFactoryMethod.Abstractions;

public abstract class NotificationFactory
{
    public abstract INotificationType CreateNotification(string recipient, string message);
}