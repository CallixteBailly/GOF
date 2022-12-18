namespace GOF.Factory.Method;

internal class Resume : ProductDescription
{
    public override void CreateProductDescription()
    {
        Sections.Add(new ShortFeature());
        Sections.Add(new ShortDetail());
    }
}