using System;
using UnitTestCoverageDemo.Calculations;

namespace UnitTestCoverageDemo.Services
{
    public class FigureService
    {
        private readonly SimpleCalculation _simpleCalculation;
        private readonly ComplexCalculation _complexCalculation;

        public FigureService()
        {
            // Who's got time for DI anyways?
            this._simpleCalculation = new SimpleCalculation();
            this._complexCalculation = new ComplexCalculation();
        }

        public Int32 SquareArea(Int32 s)
        {
            var area = this._complexCalculation.Power(s, 2);

            return area;
        }

        public Int32 RectangleArea(Int32 b, Int32 h)
        {
            var area = this._simpleCalculation.Multiply(b, h);

            return area;
        }

        public Int32 TriangleArea(Int32 b, Int32 h)
        {
            var doubleArea = this._simpleCalculation.Multiply(b, h);
            var area = this._simpleCalculation.Divide(doubleArea, 2);

            return area;
        }

        public Int32 RectanglePerimeter(Int32 b, Int32 h)
        {
            var halfPerimeter = this._simpleCalculation.Add(b, h);
            var perimeter = this._simpleCalculation.Multiply(halfPerimeter, 2);

            return perimeter;
        }
    }
}