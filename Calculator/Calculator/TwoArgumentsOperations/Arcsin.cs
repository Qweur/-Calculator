using System;

namespace Calculator.TwoArgumentsOperations
{
    public class Arcsin : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Asin(first);
        }
    }
}
