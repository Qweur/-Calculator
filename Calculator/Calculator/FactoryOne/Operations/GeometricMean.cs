using System;

namespace Calculator.FactoryOne.Operations
{
    class GeometricMean : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Sqrt(first*second);
        }
    }
}
