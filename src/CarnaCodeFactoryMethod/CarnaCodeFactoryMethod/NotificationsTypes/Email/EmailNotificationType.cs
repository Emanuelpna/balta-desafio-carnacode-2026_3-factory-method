using CarnaCodeFactoryMethod.Abstractions;

namespace CarnaCodeFactoryMethod.NotificationsTypes.Email;

public sealed class EmailNotificationType : INotificationType
{
    public string Recipient { get; set; }
    public string Message { get; set; }

    public string Subject { get; set; }
    public bool IsHtml { get; set; }
    
    public EmailNotificationType(string recipient, string subject, string message, bool isHtml)
    {
        Recipient = recipient;
        Message = message;
        Subject = subject;
        IsHtml = isHtml;
    }

    public void SendNotification()
    {
        Console.WriteLine($"📧 Enviando Email para {Recipient}");
        Console.WriteLine($"   Assunto: {Subject}");
        Console.WriteLine($"   Mensagem: {Message}");
    }
}