using LearnIsbnKata.Test.helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnIsbnKata.Test
{
    public class ISBNValidator 
    {
        private const int isbn10Length = 10;
        private readonly bool isIsbn10;
        private readonly string isbn;
        private readonly RemoveSpaceAndHypen removeSpaceAndHypen = new();
        private readonly DigitValidator digitValidator = new();
        private readonly ISBNCheckSum iSBNCheckSum = new();

        public ISBNValidator(string isbn)
        {
            this.isbn = isbn;

            isIsbn10 = 
                (isbn.Length == isbn10Length) ? true : false;

        }

        public bool IsValid()
        {
            string isbnCleaned = removeSpaceAndHypen.CleanISBN(isbn);

            if (digitValidator.IsCharsValid(isbnCleaned) == false)
            {
                return false;
            }

            if (digitValidator.IsWrongLength(isbnCleaned))
            {
                return false;
            }

            return iSBNCheckSum.IsCheckSumValid(isbnCleaned, isIsbn10);

        }


    }
}