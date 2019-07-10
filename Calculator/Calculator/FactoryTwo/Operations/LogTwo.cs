using System;

namespace Calculator.FactoryTwo.Operations
{
    public class LogTwo : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Log(first,2);
        }
    }
}
