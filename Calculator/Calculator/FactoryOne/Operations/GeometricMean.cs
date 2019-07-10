using System;

namespace Calculator.FactoryOne.Operations
{
     public class GeometricMean : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Sqrt(first*second);
        }
    }
}
