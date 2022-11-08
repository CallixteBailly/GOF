namespace GOF.Bridge;

public class StandardArticle : Article
{
    public override void ToOrder()
    {
        Console.WriteLine("ToOrder() => Specific To Order Standard Article");
    }
}