using System;

namespace Calculator.FactoryOne.Operations
{
  public  class Root : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, 1 / second);
        }
    }
}
