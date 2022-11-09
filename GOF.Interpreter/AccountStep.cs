namespace GOF.Interpreter;
public class AccountStep : Step
{
    private const string INFORMATION = "E";
    private const string ADDRESS = "F";
    private const string COLLECTION_ACCOUNT = "G";
    private const string ORDER = "H";
    public override string Page1()
    {
        return INFORMATION;
    }

    public override string Page2()
    {
        return ADDRESS;
    }

    public override string Page3()
    {
        return COLLECTION_ACCOUNT;
    }

    public override string Page4()
    {
        return ORDER;
    }

    public override string Rules(string input)
    {
        return " > " + input switch
        {
            INFORMATION => "Information",
            ADDRESS => "address",
            COLLECTION_ACCOUNT => "Collection",
            ORDER => "Order",
            _ => string.Empty,
        };
    }
}
