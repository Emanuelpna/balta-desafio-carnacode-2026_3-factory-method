namespace CarnaCodeFactoryMethod.Abstractions;

public abstract class Notification
{
    public abstract void SendEmailNotification(string recipient);
    public abstract void SendSmsNotification(string recipient);
    public abstract void SendPushNotification(string recipient);
    public abstract void SendWhatsAppNotification(string recipient);
}