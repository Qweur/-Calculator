using System;

namespace Calculator.FactoryTwo.Operations
{
    public class Sin : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Sin(first);
        }
    }
}
