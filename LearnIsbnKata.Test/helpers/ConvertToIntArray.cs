using System;
using System.Collections.Generic;

namespace LearnIsbnKata.Test.helpers
{
    public class ConvertToIntArray
    {
        private const int IntValueForX = 10;

        public static List<int> Get(string isbn, bool isIsbn10)
        {
            List<int> isbnArray = new();
            char[] cs = isbn.ToCharArray();

            for (int i = 0; i < cs.Length; i++)
            {
                if (IsLastCharValueXAndIsbn10(isIsbn10, cs, i))
                {
                    isbnArray.Add(IntValueForX);
                    continue;
                }

                isbnArray.Add(Int32.Parse(cs[i].ToString()));
            }

            return isbnArray;
        }

        private static bool IsLastCharValueXAndIsbn10(bool isIsbn10, char[] cs, int i)
        {
            return (cs.Length - 1) == i && cs[i] == 'X' && isIsbn10;
        }
    }
}