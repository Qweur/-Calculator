using System;

namespace Calculator
{
    class RootExtraction : IOneArgumentsCalculator
    {
    public double CalculateTwo(double first)
    {
        return Math.Sqrt(first);
    }
    }
}