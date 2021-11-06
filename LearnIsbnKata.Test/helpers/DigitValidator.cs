namespace LearnIsbnKata.Test
{
    public class DigitValidator
    {
        private const int isbn13Length = 13;
        private const int isbn10Length = 10;
        public bool IsCharsValid(string str)
        {
            char[] cStrs = str.ToUpper().ToCharArray();

            for (int i = 0; i < cStrs.Length; i++)
            {

                if (IsLastCharValueX(cStrs, i))
                {
                    continue;
                }

                if (cStrs[i] < '0' || cStrs[i] > '9')
                {
                    return false;
                }

            }

            return true;
        }

        private static bool IsLastCharValueX(char[] cStrs, int i) 
            => (cStrs.Length - 1) == i && cStrs[i] == 'X';

        public bool IsWrongLength(string isbnCleaned)
        {
            if (isbnCleaned.Length == isbn13Length
                || isbnCleaned.Length == isbn10Length)
            {
                return false;
            }
            return true;
        }
    }
}