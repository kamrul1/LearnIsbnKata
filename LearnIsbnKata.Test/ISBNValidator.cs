using LearnIsbnKata.Test.helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnIsbnKata.Test
{
    public class ISBNValidator 
    {
        private const int isbn13Length = 13;
        private readonly string isbn;
        private readonly RemoveSpaceAndHypen removeSpaceAndHypen = new();
        private readonly DigitValidator digitValidator = new();

        public ISBNValidator(string isbn)
        {
            this.isbn = isbn;
        }

        public bool IsValid()
        {
            string isbnCleaned = removeSpaceAndHypen.CleanISBN(isbn);

            if (digitValidator.IsValid(isbnCleaned) == false)
            {
                return false;
            }

            if (IsWrongLength(isbnCleaned))
            {
                return false;
            }

            return IsCheckSumValid(isbnCleaned);

        }

        internal static bool IsWrongLength(string isbnCleaned)
        {
            return isbnCleaned.Length != isbn13Length;
        }

        protected bool IsCheckSumValid(string isbn)
        {
            int module10Value, checkSumLastDigit;
            CalculateModuleAndCheckSum(isbn, out module10Value, out checkSumLastDigit);

            if (ZeroModule10IsTheZeroCheckSum(module10Value, checkSumLastDigit))
            {
                return true;
            }

            return IsCheckSumLastDigit(module10Value, checkSumLastDigit);

        }

        private static void CalculateModuleAndCheckSum(string isbn, out int module10Value, out int checkSumLastDigit)
        {
            IReadOnlyList<int> isbnArray = ConvertToIntArray.Get(isbn);

            IReadOnlyList<int> amounts = SumEachPositionByMultipler.SumAmounts(isbnArray);

            module10Value = amounts.Sum() % 10;
            checkSumLastDigit = isbnArray.Last();
        }

        private static bool IsCheckSumLastDigit(int module10Value, int checkSumLastDigit)
        {
            var calculatedCheckSum = 10 - module10Value;
            return (calculatedCheckSum == checkSumLastDigit) ? true : false;
        }

        private static bool ZeroModule10IsTheZeroCheckSum(int module10Value, int checkSumLastDigit)
        {
            return module10Value == 0 && checkSumLastDigit == 0;
        }
    }
}