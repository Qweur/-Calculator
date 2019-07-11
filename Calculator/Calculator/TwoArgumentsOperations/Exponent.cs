using System;

namespace Calculator.TwoArgumentsOperations
{
   public class Exponent : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Exp(first);
        }
    }
}
