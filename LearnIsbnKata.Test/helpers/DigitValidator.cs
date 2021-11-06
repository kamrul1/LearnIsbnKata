namespace LearnIsbnKata.Test
{
    public class DigitValidator
    {
        internal bool IsValid(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}