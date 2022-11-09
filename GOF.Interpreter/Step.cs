namespace GOF.Interpreter;

public abstract class Step
{
    public void Interpret(Context context)
    {
        string inputRule = context.Input.FirstOrDefault().ToString();
        if (context.Input.Length == 0)
        {
            return;
        }

        if (context.Input.StartsWith(Page1()))
        {
            context.Output += Rules(inputRule);
            context.Input = context.Input[1..];
        }
        else if (context.Input.StartsWith(Page2()))
        {
            context.Output += Rules(inputRule);
            context.Input = context.Input[1..];
        }
        else if (context.Input.StartsWith(Page3()))
        {
            context.Output += Rules(inputRule);
            context.Input = context.Input[1..];
        }

        while (context.Input.StartsWith(Page4()))
        {
            context.Output += Rules(inputRule);
            context.Input = context.Input[1..];
        }
    }

    public abstract string Page1();
    public abstract string Page2();
    public abstract string Page3();
    public abstract string Page4();
    public abstract string Rules(string input);
}
