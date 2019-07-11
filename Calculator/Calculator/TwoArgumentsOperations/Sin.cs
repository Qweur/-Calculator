using System;

namespace Calculator.TwoArgumentsOperations
{
    public class Sin : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Sin(first);
        }
    }
}
