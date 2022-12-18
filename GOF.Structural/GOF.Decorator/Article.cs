namespace GOF.Decorator
{
    public abstract class Article
    {
        public string? Title { get; set; }
        public int Remanings { get; set; }
        public abstract void Display();
    }
}
