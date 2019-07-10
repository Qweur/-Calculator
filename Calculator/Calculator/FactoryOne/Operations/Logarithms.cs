using System;

namespace Calculator.FactoryOne.Operations
{
    class Logarithms : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first, second);
        }
    }
}