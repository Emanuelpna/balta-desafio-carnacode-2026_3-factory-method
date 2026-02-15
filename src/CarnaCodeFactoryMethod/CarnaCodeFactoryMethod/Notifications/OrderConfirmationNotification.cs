using CarnaCodeFactoryMethod.Abstractions;
using CarnaCodeFactoryMethod.NotificationsTypes.Email;
using CarnaCodeFactoryMethod.NotificationsTypes.Push;
using CarnaCodeFactoryMethod.NotificationsTypes.Sms;
using CarnaCodeFactoryMethod.NotificationsTypes.WhatsApp;

namespace CarnaCodeFactoryMethod.Notifications;

public sealed class OrderConfirmationNotification(string orderNumber) : Notification
{
    public override void SendEmailNotification(string recipient)
    {
        var factory = new EmailNotificationFactory("Confirmação de Pedido", true);
        var notification = factory.CreateNotification(recipient, $"Seu pedido {orderNumber} foi confirmado!");
        notification.SendNotification();
    }
    
    public override void SendSmsNotification(string recipient)
    {
        var factory = new SmsNotificationFactory();
        var notification = factory.CreateNotification(recipient, $"Pedido {orderNumber} confirmado!");
        notification.SendNotification();
    }

    public override void SendPushNotification(string recipient)
    {
        var factory = new PushNotificationFactory("Pedido Confirmado");
        var notification = factory.CreateNotification(recipient, $"Pedido {orderNumber} confirmado!");
        notification.SendNotification();
    }

    public override void SendWhatsAppNotification(string recipient)
    {
        var factory = new WhatsAppNotificationFactory(true);
        var notification = factory.CreateNotification(recipient, $"✅ Seu pedido {orderNumber} foi confirmado!");
        notification.SendNotification();
    }
}