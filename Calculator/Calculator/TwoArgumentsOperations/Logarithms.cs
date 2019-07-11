using System;

namespace Calculator.TwoArgumentsOperations
{
    public class Logarithms : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first, second);
        }
    }
}