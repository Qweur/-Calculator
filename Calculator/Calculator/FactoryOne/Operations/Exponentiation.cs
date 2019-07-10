using System;

namespace Calculator.FactoryOne.Operations
{
    class Exponentiation : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}
