using System;

namespace Calculator.FactoryTwo.Operations
{
    class Sin : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Sin(first);
        }
    }
}
