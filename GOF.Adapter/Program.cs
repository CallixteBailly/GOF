using GOF.Adapter;
// Non-adapted chemical compound
Article article = new();
article.Display();
// Adapted chemical compounds
Article sdArticle = new ArticleAdapter(ArticleType.Standard);
sdArticle.Display();
Article mpArticle = new ArticleAdapter(ArticleType.MarketPlace);
mpArticle.Display();
Article dArticle = new ArticleAdapter(ArticleType.Digital);
dArticle.Display();
// Wait for user
Console.ReadKey();