using System;

namespace Calculator.FactoryTwo.Operations
{
   public class Exponent : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Exp(first);
        }
    }
}
