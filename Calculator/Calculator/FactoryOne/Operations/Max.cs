using System;

namespace Calculator.FactoryOne.Operations
{
    class Max : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Max(first,second);
        }
    }
}
