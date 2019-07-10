using System;

namespace Calculator.FactoryTwo.Operations
{
    public class LnX : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Log(first,Math.E);
        }
    }
}
