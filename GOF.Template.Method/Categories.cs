namespace GOF.Template.Method;

public class Categories : DataAccessor
{
    private List<string>? categories;

    public override void Connect()
    {
        categories = new List<string>();
    }

    public override void Select()
    {
        categories?.Add("Laptop");
        categories?.Add("Smartphone");
        categories?.Add("TV");
        categories?.Add("Gaming");
        categories?.Add("Book");
        categories?.Add("Digital");
    }

    public override void Process(int top)
    {
        Console.WriteLine("Categories ---- ");

        for (int i = 0; i < top; i++)
        {
            Console.WriteLine(categories?[i]);
        }

        Console.WriteLine();
    }

    public override void Disconnect()
    {
        categories?.Clear();
    }
}
