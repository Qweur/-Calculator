using System;

namespace Calculator.FactoryOne.Operations
{
    public class Logarithms : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first, second);
        }
    }
}