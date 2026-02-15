using CarnaCodeFactoryMethod.Abstractions;

namespace CarnaCodeFactoryMethod.NotificationsTypes.Sms;

public sealed class SmsNotificationType : INotificationType
{
    public string Recipient { get; set; }
    public string Message { get; set; }
    
    public SmsNotificationType(string recipient, string message)
    {
        Recipient = recipient;
        Message = message;
    }

    public void SendNotification()
    {
        Console.WriteLine($"📱 Enviando SMS para {Recipient}");
        Console.WriteLine($"   Mensagem: {Message}");
    }
}