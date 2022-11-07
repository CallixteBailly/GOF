namespace GOF.Factory.Method;

internal class Full : ProductDescription
{
    public override void CreateProductDescription()
    {
        Sections.Add(new Review());
        Sections.Add(new Tips());
        Sections.Add(new Comment());
        Sections.Add(new Feature());
        Sections.Add(new Detail());
    }
}