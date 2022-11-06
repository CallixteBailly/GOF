using GOF.Builder;

ArticleBuilder builder;
// Create shop with article builders
Order shop = new();
// Construct and display articles
builder = new StandardArticleBuilder();
shop.Construct(builder);
builder.Article.Show();
builder = new MarketPlaceArticleBuilder();
shop.Construct(builder);
builder.Article.Show();
builder = new DigitalArticleBuilder();
shop.Construct(builder);
builder.Article.Show();
// Wait for user
Console.ReadKey();