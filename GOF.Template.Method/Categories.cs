namespace GOF.Template.Method;

public class Categories : DataAccessor
{
    private List<string>? _categories;

    public override void Connect()
    {
        _categories = new List<string>();
    }

    public override void Select()
    {
        _categories?.Add("Laptop");
        _categories?.Add("Smartphone");
        _categories?.Add("TV");
        _categories?.Add("Gaming");
        _categories?.Add("Book");
        _categories?.Add("Digital");
    }

    public override void Process(int top)
    {
        Console.WriteLine("Categories ---- ");

        for (int i = 0; i < top; i++)
        {
            Console.WriteLine(_categories?[i]);
        }

        Console.WriteLine();
    }

    public override void Disconnect()
    {
        _categories?.Clear();
    }
}
