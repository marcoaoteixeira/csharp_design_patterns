// Note: constructors call Factory Method
using FactoryMethod;
using FactoryMethod.Documents;

var documents = new Document[] {
    new ResumeDocument(),
    new ReportDocument()
};
// Display document pages
foreach (var document in documents) {
    Console.WriteLine("\n" + document.GetType().Name + "--");
    foreach (var page in document.GetPages()) {
        Console.WriteLine(" " + page.GetType().Name);
    }
}
// Wait for user
Console.ReadKey();
