namespace GOF.Template.Method;

public class Items : DataAccessor
{
    private List<string>? products;

    public override void Connect()
    {
        products = new List<string>();
    }

    public override void Select()
    {
        products?.Add("Iphone 14 Pro Max");
        products?.Add("Iphone 13 Pro");
        products?.Add("S22 Ultra");
        products?.Add("S22");
        products?.Add("TV Philips Hue 75");
        products?.Add("Laptop Windows 11");
    }

    public override void Process(int top)
    {
        Console.WriteLine("Products ---- ");

        for (int i = 0; i < top; i++)
        {
            Console.WriteLine(products?[i]);
        }

        Console.WriteLine();
    }

    public override void Disconnect()
    {
        products?.Clear();
    }
}
