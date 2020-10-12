using System;
using UnitTestCoverageDemo.Calculations;

namespace UnitTestCoverageDemo.Services
{
    public class MoneyService
    {
        private readonly SimpleCalculation _simpleCalculation;
        private readonly ComplexCalculation _complexCalculation;

        public MoneyService()
        {
            // Who's got time for DI anyways?
            this._simpleCalculation = new SimpleCalculation();
            this._complexCalculation = new ComplexCalculation();
        }

        public Int32 Spend(Int32 money, Int32 price)
        {
            if (money < price)
            {
                throw new ArgumentOutOfRangeException(nameof(price));
            }

            var left = this._simpleCalculation.Substract(money, price);

            return left;
        }

        public Int32 ForgetTheChange(Decimal money)
        {
            var withoutTheChange = this._complexCalculation.Round(money);

            return withoutTheChange;
        }
    }
}