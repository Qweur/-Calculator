using System;

namespace Calculator.TwoArgumentsOperations
{
  public  class Radians : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return first * (Math.PI / 180);
        }
    }
}
