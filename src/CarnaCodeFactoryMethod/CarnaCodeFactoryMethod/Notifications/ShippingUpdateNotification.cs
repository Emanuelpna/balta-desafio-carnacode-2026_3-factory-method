using CarnaCodeFactoryMethod.Abstractions;
using CarnaCodeFactoryMethod.NotificationsTypes.Email;
using CarnaCodeFactoryMethod.NotificationsTypes.Push;
using CarnaCodeFactoryMethod.NotificationsTypes.Sms;
using CarnaCodeFactoryMethod.NotificationsTypes.WhatsApp;

namespace CarnaCodeFactoryMethod.Notifications;

public sealed class ShippingUpdateNotification(string trackingCode) : Notification
{
    public override void SendEmailNotification(string recipient)
    {
        var factory = new EmailNotificationFactory("Pedido Enviado", true);
        var notification = factory.CreateNotification(recipient, $"Seu pedido foi enviado! Código de rastreamento: {trackingCode}");
        notification.SendNotification();
    }
    
    public override void SendSmsNotification(string recipient)
    {
        var factory = new SmsNotificationFactory();
        var notification = factory.CreateNotification(recipient, $"Pedido enviado! Rastreamento: {trackingCode}");
        notification.SendNotification();
    }

    public override void SendPushNotification(string recipient)
    {
        var factory = new PushNotificationFactory("Pedido Enviado");
        var notification = factory.CreateNotification(recipient, $"Rastreamento: {trackingCode}");
        notification.SendNotification();
    }

    public override void SendWhatsAppNotification(string recipient)
    {
        var factory = new WhatsAppNotificationFactory(true);
        var notification = factory.CreateNotification(recipient, $"📦 Pedido enviado! Rastreamento: {trackingCode}");
        notification.SendNotification();
    }
}