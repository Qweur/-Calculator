using System;

namespace Calculator.FactoryTwo.Operations
{
    class LogTwo : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Log(first,2);
        }
    }
}
