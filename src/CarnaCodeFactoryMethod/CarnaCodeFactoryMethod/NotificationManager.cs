using CarnaCodeFactoryMethod.Abstractions;
using CarnaCodeFactoryMethod.Notifications;

namespace CarnaCodeFactoryMethod;

public class NotificationManager
{
    public void SendOrderConfirmation(string recipient, string orderNumber, string notificationType)
    {
        SendNotification(notificationType, recipient, new OrderConfirmationNotification(orderNumber));
    }

    public void SendShippingUpdate(string recipient, string trackingCode, string notificationType)
    {
        SendNotification(notificationType, recipient, new ShippingUpdateNotification(trackingCode));
    }

    public void SendPaymentReminder(string recipient, decimal amount, string notificationType)
    {
        SendNotification(notificationType, recipient, new PaymentReminderNotification(amount));
    }

    private void SendNotification(string notificationType, string recipient, Notification notification)
    {
        switch (notificationType)
        {
            case "email":
                notification.SendEmailNotification(recipient);
                break;
            case "sms":
                notification.SendSmsNotification(recipient);
                break;
            case "push":
                notification.SendPushNotification(recipient);
                break;
            case "whatsapp":
                notification.SendWhatsAppNotification(recipient);
                break;
            default:
                throw new ArgumentException($"Tipo de notificação '{notificationType}' não suportado");
        }
    }
}