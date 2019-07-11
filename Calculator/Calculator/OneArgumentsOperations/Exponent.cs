using System;

namespace Calculator.OneArgumentsOperations
{
   public class Exponent : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Exp(first);
        }
    }
}
