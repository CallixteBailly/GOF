namespace GOF.Command;
internal class EmailCommand : ICommand
{
    private readonly IReceiver _receiver;
    private readonly string _a;
    private readonly string _b;

    public EmailCommand(IReceiver receiver, string a, string b)
    {
        _receiver = receiver;
        _a = a;
        _b = b;
    }

    public void Execute()
    {
        Console.WriteLine("EmailCommand: Send a email.");
        _receiver.DoSomething(_a);
        _receiver.DoSomethingElse(_b);
    }
}
