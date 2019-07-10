using System;

namespace Calculator.FactoryTwo.Operations
{
    public class RootExtraction : IOneArgumentsCalculator
    {
    public double CalculateTwo(double first)
    {
        return Math.Sqrt(first);
    }
    }
}