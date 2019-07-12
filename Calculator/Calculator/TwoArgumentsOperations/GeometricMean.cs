using System;

namespace Calculator.TwoArgumentsOperations
{
    /// <summary>
    /// Count Geometric Mean
    /// </summary>
    public class GeometricMean : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Finding Geometric Mean
        /// </summary>
        /// <param name="first">
        /// Value of the first parameter
        /// </param>
        /// <param name="second">
        /// Value of the second parameter
        /// </param>
        /// <returns>
        /// Return Geometric Mean
        /// </returns>
        public double Calculate(double first, double second)
        {
            return Math.Sqrt(first * second);
        }
    }
}