namespace GOF.Mediator;

public class Customer : Participant
{
    public Customer(string name)
        : base(name)
    {
    }

    public override void Receive(string from, string message)
    {
        Console.Write("To a customer: ");
        base.Receive(from, message);
    }
}
