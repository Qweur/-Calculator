using System;

namespace Calculator.FactoryTwo.Operations
{
    class LnX : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Log(first,Math.E);
        }
    }
}
