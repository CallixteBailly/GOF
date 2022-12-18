namespace GOF.Interpreter;

public class PipeStep : Step
{
    private const string CART_PIPE = "M";
    private const string WISHLIST = "N";
    private const string PAYEMENT = "O";
    private const string LOGIN_PIPE = "P";
    public override string Page1()
    {
        return CART_PIPE;
    }

    public override string Page2()
    {
        return WISHLIST;
    }

    public override string Page3()
    {
        return PAYEMENT;
    }

    public override string Page4()
    {
        return LOGIN_PIPE;
    }

    public override string Rules(string input)
    {
        return " > " + input switch
        {
            CART_PIPE => "Cart",
            WISHLIST => "Wishlist",
            PAYEMENT => "Payement",
            LOGIN_PIPE => "Login pipe",
            _ => string.Empty,
        };
    }
}
