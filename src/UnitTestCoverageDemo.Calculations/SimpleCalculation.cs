using System;

namespace UnitTestCoverageDemo.Calculations
{
    public class SimpleCalculation
    {
        public Int32 Add(Int32 n, Int32 m)
        {
            return n + m;
        }

        public Int32 Substract(Int32 n, Int32 m)
        {
            return n - m;
        }

        public Int32 Multiply(Int32 n, Int32 m)
        {
            return n * m;
        }

        public Int32 Divide(Int32 n, Int32 m)
        {
            if (m == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(m));
            }

            return n / m;
        }
    }
}