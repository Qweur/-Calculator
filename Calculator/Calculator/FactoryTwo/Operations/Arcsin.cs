using System;

namespace Calculator.FactoryTwo.Operations
{
    public class Arcsin : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Asin(first);
        }
    }
}
