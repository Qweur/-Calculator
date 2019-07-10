using System;
using Calculator.FactoryOne;

namespace Calculator
{
    public class Min : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Min(first, second);
        }
    }
}