namespace GOF.Mediator;

public class Program
{
    public static void Main(string[] args)
    {
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
