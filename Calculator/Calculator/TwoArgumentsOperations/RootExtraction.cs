using System;

namespace Calculator.TwoArgumentsOperations
{
    public class RootExtraction : IOneArgumentsCalculator
    {
    public double CalculateTwo(double first)
    {
        return Math.Sqrt(first);
    }
    }
}