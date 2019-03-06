using System;
using Xunit;

namespace StringTDDKata.Tests
{
    public class StringCalculatorTests
    {
        StringCalculator sut;

        public StringCalculatorTests()
        {
            sut = new StringCalculator();
        }

        [Fact]
        public void Add_Returns_0_For_Empty_String()
        {
            var result = sut.Add("");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Add_Returns_1_For_1()
        {
            var result = sut.Add("1");
            Assert.Equal(1, result);
        }
    }
}
