using GOF.Builder;

ArticleBuilder builder;
// Create shop with article builders
// Construct and display articles
builder = new StandardArticleBuilder();
Order.Construct(builder);
builder.Article.Show();
builder = new MarketPlaceArticleBuilder();
Order.Construct(builder);
builder.Article.Show();
builder = new DigitalArticleBuilder();
Order.Construct(builder);
builder.Article.Show();
// Wait for user
Console.ReadKey();
