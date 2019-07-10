using System;

namespace Calculator.FactoryTwo.Operations
{
    class Exponent : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Exp(first);
        }
    }
}
