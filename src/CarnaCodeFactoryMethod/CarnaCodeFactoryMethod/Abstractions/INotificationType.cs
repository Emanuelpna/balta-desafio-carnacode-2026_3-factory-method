namespace CarnaCodeFactoryMethod.Abstractions;

public interface INotificationType
{
    public string Recipient { get; set; }
    public string Message { get; set; }
    
    void SendNotification();
}