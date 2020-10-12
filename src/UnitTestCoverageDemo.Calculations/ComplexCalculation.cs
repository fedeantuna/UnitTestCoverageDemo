using System;

namespace UnitTestCoverageDemo.Calculations
{
    public class ComplexCalculation
    {
        public Int32 Power(Int32 n, Int32 m)
        {
            if (m == 0)
            {
                return 1;
            }

            var result = n;
            for (int i = 1; i < m; i++)
            {
                result *= n;
            }

            return result;
        }

        public Int32 Round(Decimal n)
        {
            var intPart = (Int32)n;
            var difference = n - intPart;

            if (difference >= 0.5M)
            {
                return intPart + 1;
            }

            return intPart;
        }
    }
}