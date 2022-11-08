namespace GOF.ChainOfResp;
public static class Program
{
    public static void Main(string[] args)
    {
        if (args == null)
            throw new ArgumentNullException(nameof(args));
        // Setup Chain of Responsibility

        Approver claimLow = new ClaimLvlLow();
        Approver claimMedium = new ClaimLvlMedium();
        Approver claimHigh = new ClaimLvlHigh();

        claimLow.SetSuccessor(claimMedium);
        claimMedium.SetSuccessor(claimHigh);

        // Generate and process purchase claims

        Purchase p = new(100, 1399, "Iphone 14 pro 258go");
        claimLow.ProcessRequest(p);

        p = new Purchase(101, 1999, "Smasung fold 4 500go");
        claimLow.ProcessRequest(p);

        p = new Purchase(102, 10099, "Samsung View 8K 75");
        claimLow.ProcessRequest(p);

        // Wait for user

        Console.ReadKey();
    }
}
