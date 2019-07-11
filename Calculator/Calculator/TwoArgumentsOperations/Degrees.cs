using System;

namespace Calculator.TwoArgumentsOperations
{
   public class Degrees : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return first * (180 / Math.PI);
        }
    }
}
