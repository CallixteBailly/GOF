using GOF.Bridge;
ArticleAbstraction ab = new RefinedArticleAbstraction
{
    // Set implementation and call
    Article = new StandardArticle()
};
ab.ToOrder();
// Change implemention and call
ab.Article = new MarketPlaceArticle();
ab.ToOrder();
// Wait for user
Console.ReadKey();
