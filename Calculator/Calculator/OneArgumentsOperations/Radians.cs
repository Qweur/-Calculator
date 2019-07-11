using System;

namespace Calculator.OneArgumentsOperations
{
  public  class Radians : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return first * (Math.PI / 180);
        }
    }
}
