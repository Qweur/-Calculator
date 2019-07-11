using System;

namespace Calculator.OneArgumentsOperations
{
    public class Min : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Min(first, second);
        }
    }
}