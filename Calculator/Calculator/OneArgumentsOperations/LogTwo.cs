using System;

namespace Calculator.OneArgumentsOperations
{
    public class LogTwo : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Log(first,2);
        }
    }
}
