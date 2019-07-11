using System;

namespace Calculator.TwoArgumentsOperations
{
    public class CTan : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return 1/ Math.Tan(first);
        }
    }
}
