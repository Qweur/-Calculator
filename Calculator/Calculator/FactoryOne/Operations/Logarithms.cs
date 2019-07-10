using System;
using Calculator.FactoryOne;
using Calculator.FactoryTwo;

namespace Calculator._10
{
    class Logarithms : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first, second);
        }
    }
}