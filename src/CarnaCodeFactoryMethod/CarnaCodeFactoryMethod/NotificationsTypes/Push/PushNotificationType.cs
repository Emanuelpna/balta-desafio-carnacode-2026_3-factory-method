using CarnaCodeFactoryMethod.Abstractions;

namespace CarnaCodeFactoryMethod.NotificationsTypes.Push;

public sealed class PushNotificationType : INotificationType
{
    public string Recipient { get; set; }
    public string Message { get; set; }

    public string Title { get; set; }

    public PushNotificationType(string recipient, string message, string title)
    {
        Recipient = recipient;
        Message = message;
        Title = title;
    }
    
    public void SendNotification()
    {
        Console.WriteLine($"🔔 Enviando Push para dispositivo {Recipient}");
        Console.WriteLine($"   Título: {Title}");
        Console.WriteLine($"   Mensagem: {Message}");
    }
}