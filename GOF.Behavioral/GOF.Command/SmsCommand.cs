namespace GOF.Command;
internal class SmsCommand : ICommand
{
    private readonly string _payload = string.Empty;

    public SmsCommand(string payload)
    {
        _payload = payload;
    }

    public void Execute()
    {
        Console.WriteLine($"SmsCommand: Send a text message ({_payload})");
    }
}
