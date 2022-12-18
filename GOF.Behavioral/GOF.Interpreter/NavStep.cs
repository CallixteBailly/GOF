namespace GOF.Interpreter;

public class NavStep : Step
{
    private const string CATEGORY_NAV = "I";
    private const string PROMOTION = "J";
    private const string ITEM = "K";
    private const string SEARCH = "L";
    public override string Page1()
    {
        return CATEGORY_NAV;
    }

    public override string Page2()
    {
        return PROMOTION;
    }

    public override string Page3()
    {
        return ITEM;
    }

    public override string Page4()
    {
        return SEARCH;
    }

    public override string Rules(string input)
    {
        return " > " + input switch
        {
            CATEGORY_NAV => "Category",
            PROMOTION => "Promotion",
            ITEM => "Item",
            SEARCH => "Search",
            _ => string.Empty,
        };
    }
}
