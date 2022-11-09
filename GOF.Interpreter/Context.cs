namespace GOF.Interpreter
{
    public class Context
    {
        public string Input { get; set; } = null!;
        public string Output { get; set; } = null!;

        // Constructor

        public Context(string input)
        {
            Input = input;
        }
    }
}
