using System;

namespace Calculator.TwoArgumentsOperations
{
   public class Cos : IOneArgumentsCalculator
    {
    public double CalculateTwo(double first)
    {
        return Math.Cos(first);
    }

    }
}
