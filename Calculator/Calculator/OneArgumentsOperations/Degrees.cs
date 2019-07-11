using System;

namespace Calculator.OneArgumentsOperations
{
   public class Degrees : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return first * (180 / Math.PI);
        }
    }
}
