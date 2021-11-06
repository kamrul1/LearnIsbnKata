using System.Collections.Generic;
using System.Linq;

namespace LearnIsbnKata.Test.helpers
{
    public class ISBNCheckSum
    {
        private const int isbn13ModuleValue = 10;
        private const int isbn10ModuleValue = 11;


        public bool IsCheckSumValid(string isbn, bool isIsbn10)
        {

            CalculateModuleAndCheckSum(isbn, isIsbn10, out int moduleReminder, out int checkSumLastDigit);

            if (ZeroModule10IsTheZeroCheckSum(moduleReminder, checkSumLastDigit))
            {
                return true;
            }

            return IsCheckSumLastDigit(moduleReminder, checkSumLastDigit, isIsbn10);

        }
        private static void CalculateModuleAndCheckSum(string isbn, bool isIsbn10, out int moduleReminder, out int checkSumLastDigit)
        {
            IReadOnlyList<int> isbnArray = ConvertToIntArray.Get(isbn, isIsbn10);

            moduleReminder = GetModuleValue(isbnArray, isIsbn10);
            checkSumLastDigit = isbnArray.Last();
        }

        private static int GetModuleValue(IReadOnlyList<int> isbnArray, bool isIsbn10)
        {
            int moduleReminder;
            IReadOnlyList<int> amounts;
            if (isIsbn10)
            {
                amounts = SumPositionForISBN10.SumAmounts(isbnArray);
                moduleReminder = amounts.Sum() % isbn10ModuleValue;
                return moduleReminder;
            }

            amounts = SumPositionForISBN13.SumAmounts(isbnArray);
            moduleReminder = amounts.Sum() % isbn13ModuleValue;
            return moduleReminder;
        }

        private static bool IsCheckSumLastDigit(int moduleReminder, int checkSumLastDigit, bool isIsbn10)
        {
            int calculatedCheckSum = isIsbn10 ? moduleReminder : 10 - moduleReminder;
            return calculatedCheckSum == checkSumLastDigit ? true : false;
        }

        private static bool ZeroModule10IsTheZeroCheckSum(int moduleValue, int checkSumLastDigit) 
            => moduleValue == 0 && checkSumLastDigit == 0;

    }
}