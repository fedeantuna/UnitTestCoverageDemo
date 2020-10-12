using System;
using Xunit;

namespace UnitTestCoverageDemo.Services.Tests
{
    public class MoneyServiceTests
    {
        private readonly MoneyService _sut;

        public MoneyServiceTests()
        {
            this._sut = new MoneyService();
        }

        [Theory]
        [InlineData(200, 50, 150)]
        [InlineData(300, 300, 0)]
        public void Spend_Returns_RemainingMoney(Int32 money, Int32 price, Int32 remaining)
        {
            // Arrange

            // Act
            var result = this._sut.Spend(money, price);

            // Assert
            Assert.Equal(remaining, result);
        }

        [Theory]
        [InlineData(10.89, 11)]
        [InlineData(250.35, 250)]
        public void ForgetTheChange_Returns_RoundedMoney(Decimal money, Int32 rounded)
        {
            // Arrange

            // Act
            var result = this._sut.ForgetTheChange(money);

            // Assert
            Assert.Equal(rounded, result);
        }
    }
}