namespace GOF.Command;
internal class Receiver
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
