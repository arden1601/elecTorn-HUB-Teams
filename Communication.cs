namespace elecTorn_HUB_Teams;

public class Communication
{
    public string? Sender { get; set; }
    public string? Receiver { get; set; }
    public string? MessageContent { get; set; }

    public void SendMessage()
    {
        if (MessageContent == null)
        {
            throw new ArgumentNullException("there is no message");
        }
        Console.WriteLine(MessageContent);
    }

    public void ReceiveMessage()
    {
        if (MessageContent == null)
        {
            throw new ArgumentNullException("there is no message");
        }
        Console.WriteLine("this is write line logic");
    }
}