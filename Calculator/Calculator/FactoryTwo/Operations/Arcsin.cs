using System;

namespace Calculator.FactoryTwo.Operations
{
    class Arcsin : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Asin(first);
        }
    }
}
