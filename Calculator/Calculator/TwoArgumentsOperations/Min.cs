using System;

namespace Calculator.TwoArgumentsOperations
{
    public class Min : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Min(first, second);
        }
    }
}