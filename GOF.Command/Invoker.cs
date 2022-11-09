namespace GOF.Command;

internal class Invoker
{
    private ICommand? _onSms;

    private ICommand? _onEmail;

    public void SetOnSms(ICommand command)
    {
        _onSms = command;
    }

    public void SetOnEmail(ICommand command)
    {
        _onEmail = command;
    }
    public void DoSomethingImportant()
    {
        Console.WriteLine("Invoker: The process of sending the sms is underway ...");
        _onSms?.Execute();

        Console.WriteLine("Invoker: The process of sending mail is in progress ...");
        _onEmail?.Execute();
    }
}
