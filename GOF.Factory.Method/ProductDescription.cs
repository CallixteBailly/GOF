namespace GOF.Factory.Method;

internal abstract class ProductDescription
{
    public IList<Section> Sections { get; set; } = new List<Section>();

    protected ProductDescription()
    {
        CreateProductDescription();
    }

    // Factory Method
    public abstract void CreateProductDescription();
}