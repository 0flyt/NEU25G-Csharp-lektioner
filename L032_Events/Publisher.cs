
class Publisher
{
    // Dessa två är inte generiska. Men får tydligare namn
    // public delegate void MessageEvent(object sender, MessageEventArgs args);
    // public event MessageEvent Message;

    public event EventHandler<MessageEventArgs> Message; // <-- Generisk EventHandler<>

    public void SendMessage(string message)
    {
        Message?.Invoke(this, new MessageEventArgs(message));
    }
}
