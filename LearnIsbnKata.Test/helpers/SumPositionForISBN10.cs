using System.Collections.Generic;

namespace LearnIsbnKata.Test.helpers
{
    public class SumPositionForISBN10
    {
        private const int length = 10;

        public static List<int> SumAmounts(IReadOnlyList<int> isbnArray)
        {
            List<int> amounts = new();

            for (int i = 0, position = 1; i < isbnArray.Count; i++, position++)
            {
                if (position == length)
                {
                    continue;
                }

                var val = isbnArray[i] * position;
                amounts.Add(val);
            }

            return amounts;
        }
    }
}