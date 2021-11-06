namespace LearnIsbnKata.Test.helpers
{
    public class RemoveSpaceAndHypen
    {
        internal string CleanISBN(string isbn)
        {
            return isbn
                    .Replace(" ", "")
                    .Replace("-", "");
        }
    }
}