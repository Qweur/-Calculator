using System;

namespace Calculator.TwoArgumentsOperations
{
    public class LnX : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Log(first,Math.E);
        }
    }
}
