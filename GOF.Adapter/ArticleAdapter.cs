using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GOF.Adapter
{
    public class ArticleAdapter : Article
    {
        public new ArticleType Type { get; set; }
        public ArticleAdapter(ArticleType type)
        {
            this.Type = type;

        }
        public override void Display()
        {
            // The Adaptee
            Name = GetName(Type);
            Category = GetCategory(Type);
            Console.WriteLine($"\nArticle Type: {Type} ------ ");
            Console.WriteLine($" Name: {Name}");
            Console.WriteLine($" Category: {Category}");
        }
        private string GetName(ArticleType type)
        {
            return (type) switch
            {
                (ArticleType.Standard) => $"GetName() => Specific  Standard {Name}",
                (ArticleType.MarketPlace) => $"GetName() => Specific MarketPlace {Name}",
                (ArticleType.Digital) => $"GetName() => Specific Digital {Name}",
                (_) => Name?.ToString() ?? string.Empty,
            };
        }
        private string GetCategory(ArticleType type)
        {
            return (type) switch
            {
                (ArticleType.Standard) => $"GetCategory() => Specific Standard {Category}",
                (ArticleType.MarketPlace) => $"GetCategory() => Specific MarketPlace {Category}",
                (ArticleType.Digital) => $"GetCategory() => Specific Digital {Category}",
                (_) => Name?.ToString() ?? string.Empty,
            };
        }        
    }
}