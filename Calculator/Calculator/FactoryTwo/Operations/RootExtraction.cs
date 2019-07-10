using System;

namespace Calculator.FactoryTwo.Operations
{
    class RootExtraction : IOneArgumentsCalculator
    {
    public double CalculateTwo(double first)
    {
        return Math.Sqrt(first);
    }
    }
}