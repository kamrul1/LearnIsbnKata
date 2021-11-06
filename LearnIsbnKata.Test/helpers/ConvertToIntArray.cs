using System;
using System.Collections.Generic;

namespace LearnIsbnKata.Test.helpers
{
    public class ConvertToIntArray
    {

        public static List<int> Get(string isbn)
        {
            List<int> isbnArray = new();

            foreach (char s in isbn.ToCharArray())
            {
                isbnArray.Add(Int32.Parse(s.ToString()));
            }

            return isbnArray;
        }
    }
}