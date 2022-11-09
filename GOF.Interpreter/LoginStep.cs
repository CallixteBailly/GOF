namespace GOF.Interpreter;

public class LoginStep : Step
{
    private const string REGISTER = "A";
    private const string REGISTER_GOOGLE = "B";
    private const string LOGIN = "C";
    private const string LOGIN_GOOGLE = "D";
    public override string Page1()
    {
        return REGISTER;
    }

    public override string Page2()
    {
        return REGISTER_GOOGLE;
    }

    public override string Page3()
    {
        return LOGIN;
    }

    public override string Page4()
    {
        return LOGIN_GOOGLE;
    }

    public override string Rules(string input)
    {
        return " > " + input switch
        {
            REGISTER => $"Register",
            REGISTER_GOOGLE => $"Register Google",
            LOGIN => $"Login",
            LOGIN_GOOGLE => "Goole",
            _ => string.Empty,
        };
    }
}
