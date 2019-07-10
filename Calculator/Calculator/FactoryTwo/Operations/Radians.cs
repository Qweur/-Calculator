using System;

namespace Calculator.FactoryTwo.Operations
{
    class Radians : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return first * Math.PI / 180;
        }
    }
}
