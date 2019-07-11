using System;

namespace Calculator.OneArgumentsOperations
{
  public class TenToTheDegree : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Pow(10, first);
        }
    }
}
