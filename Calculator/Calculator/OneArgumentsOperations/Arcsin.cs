using System;

namespace Calculator.OneArgumentsOperations
{
    public class Arcsin : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            if (first > 1 || first < -1)
                {
                    throw new Exception("Выход за пределы значения");
                }
                return Math.Asin(first);
        }
    }
}
