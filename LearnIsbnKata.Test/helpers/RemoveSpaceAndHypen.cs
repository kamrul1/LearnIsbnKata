namespace LearnIsbnKata.Test.helpers
{
    public class RemoveSpaceAndHypen
    {
        public string CleanISBN(string isbn) => isbn
                    .Replace(" ", "")
                    .Replace("-", "");
    }
}