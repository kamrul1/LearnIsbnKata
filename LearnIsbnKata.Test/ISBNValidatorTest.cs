using System;
using Xunit;

namespace LearnIsbnKata.Test
{
    public class ISBNValidatorTest
    {
        [Theory]
        [InlineData("1234567891111",false)]
        //[InlineData("123 456789 11 11", true)]
        //[InlineData("123-456789-11-11", true)]
        //[InlineData("123456789111A", false)]
        public void ShouldReturnFalseForIsWrongLengthISBN13(
            string inputDigits, bool expectedResult)
        {

            var result = ISBNValidator.IsWrongLength(inputDigits);

            Assert.Equal(expectedResult, result);

        }

        [Theory]
        [InlineData("9780470059029")]
        [InlineData("978 0 471 48648 0")]
        [InlineData("978-0596809485")]
        [InlineData("978-0-262-13472-9")]
        [InlineData("978-0-13-149505-0")]
        [InlineData("978-3-16-148410-0")]
        public void ShouldValidateCheckSumValue(string isbn13)
        {
            var sut = new ISBNValidator(isbn13);

            var result = sut.IsValid();

            Assert.True(result);

        }



    }
}
