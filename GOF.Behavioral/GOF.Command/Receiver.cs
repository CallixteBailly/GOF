namespace GOF.Command;
internal interface IReceiver
{
    public void DoSomething(string a);
    public void DoSomethingElse(string b);
}
internal class Receiver : IReceiver
{
    public void DoSomething(string a)
    {
        Console.WriteLine($"Receiver:({a}.)");
    }

    public void DoSomethingElse(string b)
    {
        Console.WriteLine($"Receiver:({b}.)");
    }
}
