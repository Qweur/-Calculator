using System;
using Calculator.FactoryOne;

namespace Calculator
{
    public class min : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Min(first, second);
        }
    }
}