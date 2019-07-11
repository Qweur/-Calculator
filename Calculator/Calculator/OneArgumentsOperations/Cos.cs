using System;

namespace Calculator.OneArgumentsOperations
{
   public class Cos : IOneArgumentsCalculator
    {
    public double CalculateTwo(double first)
    {
        return Math.Cos(first);
    }

    }
}
