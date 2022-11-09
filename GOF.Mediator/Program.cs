namespace GOF.Mediator;

public static class Program
{
    public static void Main(string[] args)
    {
        if (args == null)
            throw new ArgumentNullException(nameof(args));

        Chatroom chatroom = new();

        Participant George = new Support("George");
        Participant Paul = new Customer("Paul");

        chatroom.Register(George);
        chatroom.Register(Paul);

        George.Send("Paul", "Hi I need help for my order : C845SX65492");
        Paul.Send("George", "Hello Paul, what is your question ?");

        Console.ReadKey();
    }
}
