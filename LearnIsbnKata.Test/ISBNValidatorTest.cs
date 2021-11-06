using System;
using Xunit;

namespace LearnIsbnKata.Test
{
    public class ISBNValidatorTest
    {


        [Theory]
        [InlineData("9780470059029")]
        [InlineData("978 0 471 48648 0")]
        [InlineData("978-0596809485")]
        [InlineData("978-0-262-13472-9")]
        [InlineData("978-0-13-149505-0")]
        [InlineData("978-3-16-148410-0")]
        [InlineData("0471958697")]
        public void ShouldValidateCheckSumValue(string isbn)
        {
            var sut = new ISBNValidator(isbn);

            var result = sut.IsValid();

            Assert.True(result);

        }

        [Fact]
        public void ShouldValidateTrueISBN10EndingWithX()
        {
            var isbn = "043942089X";

            var sut = new ISBNValidator(isbn);

            var result = sut.IsValid();

            Assert.True(result);

        }





    }
}
