using System;

namespace Calculator.FactoryTwo.Operations
{
    class Cos : IOneArgumentsCalculator
    {
    public double CalculateTwo(double first)
    {
        return Math.Cos(first);
    }
    }
}
