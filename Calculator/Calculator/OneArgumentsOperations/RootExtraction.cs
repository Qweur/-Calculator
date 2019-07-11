using System;

namespace Calculator.OneArgumentsOperations
{
    public class RootExtraction : IOneArgumentsCalculator
    {
    public double CalculateTwo(double first)
    {
        if (first < 0)
        {
            throw new Exception("Отрицательно");
        }
            return Math.Sqrt(first);
    }
    }
}