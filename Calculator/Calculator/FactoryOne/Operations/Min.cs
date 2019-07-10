using System;

namespace Calculator.FactoryOne.Operations
{
    public class Min : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Min(first, second);
        }
    }
}