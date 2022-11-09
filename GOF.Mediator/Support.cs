namespace GOF.Mediator;

public class Support : Participant
{
    public Support(string name)
        : base(name)
    {
    }

    public override void Receive(string from, string message)
    {
        Console.Write("To a support: ");
        base.Receive(from, message);
    }
}
