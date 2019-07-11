using System;

namespace Calculator.TwoArgumentsOperations
{
     public class GeometricMean : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Sqrt(first*second);
        }
    }
}
