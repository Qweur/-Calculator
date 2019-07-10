using System;

namespace Calculator.FactoryOne.Operations
{
    public class Max : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Max(first,second);
        }
    }
}
