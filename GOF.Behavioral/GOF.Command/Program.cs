namespace GOF.Command;

internal static class Program
{
    private static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }
        Invoker invoker = new();
        invoker.SetOnSms(new SmsCommand("Say Hi!"));
        Receiver receiver = new();
        invoker.SetOnEmail(new EmailCommand(receiver, "Send email", "Save report"));

        invoker.DoSomethingImportant();
    }
}