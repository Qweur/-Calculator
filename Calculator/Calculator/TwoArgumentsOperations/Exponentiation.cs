using System;

namespace Calculator.TwoArgumentsOperations
{
   public class Exponentiation : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}
