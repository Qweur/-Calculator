using System;

namespace Calculator.TwoArgumentsOperations
{
    public class LogTwo : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Log(first,2);
        }
    }
}
