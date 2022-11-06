
ProductDescription[] productDescriptions = new ProductDescription[2];
productDescriptions[0] = new Resume();
productDescriptions[1] = new Full();
// Display document pages
foreach (var pDescrition in productDescriptions)
{
    Console.WriteLine("\n" + pDescrition.GetType().Name + "--");
    foreach (var section in pDescrition.Sections)
    {
        Console.WriteLine(" " + section.GetType().Name);
    }
}
// Wait for user
Console.ReadKey();