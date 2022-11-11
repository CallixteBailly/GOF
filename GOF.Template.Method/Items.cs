namespace GOF.Template.Method;

public class Items : DataAccessor
{
    private List<string>? _products;

    public override void Connect()
    {
        _products = new List<string>();
    }

    public override void Select()
    {
        _products?.Add("Iphone 14 Pro Max");
        _products?.Add("Iphone 13 Pro");
        _products?.Add("S22 Ultra");
        _products?.Add("S22");
        _products?.Add("TV Philips Hue 75");
        _products?.Add("Laptop Windows 11");
    }

    public override void Process(int top)
    {
        Console.WriteLine("Products ---- ");

        for (int i = 0; i < top; i++)
        {
            Console.WriteLine(_products?[i]);
        }

        Console.WriteLine();
    }

    public override void Disconnect()
    {
        _products?.Clear();
    }
}
