using System;

namespace Calculator.OneArgumentsOperations
{
   public class Exponentiation : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}
