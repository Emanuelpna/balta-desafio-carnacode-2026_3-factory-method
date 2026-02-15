using CarnaCodeFactoryMethod.Abstractions;

namespace CarnaCodeFactoryMethod.NotificationsTypes.WhatsApp;

public sealed class WhatsAppNotificationType : INotificationType
{
    public string Recipient { get; set; }
    public string Message { get; set; }
    
    public bool UseTemplate { get; set; }

    public WhatsAppNotificationType(string recipient, string message, bool useTemplate)
    {
        Recipient = recipient;
        Message = message;
        UseTemplate = useTemplate;
    }
    
    public void SendNotification()
    {
        Console.WriteLine($"💬 Enviando WhatsApp para {Recipient}");
        Console.WriteLine($"   Mensagem: {Message}");
        Console.WriteLine($"   Template: {UseTemplate}");
    }
}