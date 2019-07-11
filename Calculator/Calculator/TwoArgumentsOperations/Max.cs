using System;

namespace Calculator.TwoArgumentsOperations
{
    public class Max : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Max(first,second);
        }
    }
}
