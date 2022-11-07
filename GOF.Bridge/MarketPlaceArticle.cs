using GOF.Bridge;

public class MarketPlaceArticle : Article
{
    public override void ToOrder()
    {
        Console.WriteLine("ToOrder() => Specific To Order MarketPlace Article");
    }
}