using System;

namespace Calculator.OneArgumentsOperations
{
     public class GeometricMean : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Sqrt(first*second);
        }
    }
}
