using CarnaCodeFactoryMethod.Abstractions;
using CarnaCodeFactoryMethod.NotificationsTypes.Email;
using CarnaCodeFactoryMethod.NotificationsTypes.Push;
using CarnaCodeFactoryMethod.NotificationsTypes.Sms;
using CarnaCodeFactoryMethod.NotificationsTypes.WhatsApp;

namespace CarnaCodeFactoryMethod.Notifications;

public sealed class PaymentReminderNotification(decimal amount) : Notification
{
    public override void SendEmailNotification(string recipient)
    {
        var factory = new EmailNotificationFactory("Lembrete de Pagamento", true);
        var notification = factory.CreateNotification(recipient, $"Você tem um pagamento pendente de R$ {amount:N2}");
        notification.SendNotification();
    }
    
    public override void SendSmsNotification(string recipient)
    {
        var factory = new SmsNotificationFactory();
        var notification = factory.CreateNotification(recipient, $"Pagamento pendente: R$ {amount:N2}");
        notification.SendNotification();
    }

    public override void SendPushNotification(string recipient)
    {
        throw new NotImplementedException();
    }

    public override void SendWhatsAppNotification(string recipient)
    {
        throw new NotImplementedException();
    }
}