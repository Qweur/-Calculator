using System;

namespace Calculator.OneArgumentsOperations
{
    public class Sin : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Sin(first);
        }
    }
}
