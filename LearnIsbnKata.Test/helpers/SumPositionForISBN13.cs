using System.Collections.Generic;

namespace LearnIsbnKata.Test.helpers
{
    public class SumPositionForISBN13
    {
        private const int length = 13;
        private const int oddPositionMultipler = 1;
        private const int evenPositionMultipler = 3;

        public static List<int> SumAmounts(IReadOnlyList<int> isbnArray)
        {
            List<int> amounts = new();

            for (int i = 0, position = 1; i < isbnArray.Count; i++, position++)
            {
                if (position == length)
                {
                    continue;
                }

                if (position % 2 != 0)
                {
                    var val = isbnArray[i] * oddPositionMultipler;
                    amounts.Add(val);
                }

                if (position % 2 == 0)
                {
                    var val = isbnArray[i] * evenPositionMultipler;
                    amounts.Add(val);
                }
            }

            return amounts;
        }
    }
}