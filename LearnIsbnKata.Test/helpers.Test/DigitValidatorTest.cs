using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearnIsbnKata.Test.helpersTest
{
    public class DigitValidatorTest
    {
        [Theory]
        [InlineData("1234567891111", false)]
        [InlineData("1234567891", false)]
        public void ShouldReturnFalseForIsWrongLengthISBN13or10(
            string inputDigits, bool expectedResult)
        {

            var result = new DigitValidator().IsWrongLength(inputDigits);

            Assert.Equal(expectedResult, result);

        }
    }
}
