using System;
using Xunit;

namespace UnitTestCoverageDemo.Calculations.Tests
{
    public class ComplexCalculationTests
    {
        private readonly ComplexCalculation _sut;

        public ComplexCalculationTests()
        {
            this._sut = new ComplexCalculation();
        }

        [Theory]
        [InlineData(5, 2, 25)]
        [InlineData(2, 3, 8)]
        [InlineData(5, 0, 1)]
        public void Power_Returns_FirstParameterElevatedToTheSecondParameter(Int32 firstParameter, Int32 secondParameter, Int32 expectedResult)
        {
            // Arrange

            // Act
            var result = this._sut.Power(firstParameter, secondParameter);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(5.25, 5)]
        [InlineData(7.5, 8)]
        [InlineData(6.75, 7)]
        public void Round_Returns_RoundedNumber(Decimal number, Int32 expectedResult)
        {
            // Arrange

            // Act
            var result = this._sut.Round(number);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}