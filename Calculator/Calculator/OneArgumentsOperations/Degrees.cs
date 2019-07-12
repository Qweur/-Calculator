using System;

namespace Calculator.OneArgumentsOperations
{
    /// <summary>
    /// Count Degrees
    /// </summary>
    public class Degrees : IOneArgumentsCalculator
    {
        /// <summary>
        /// Finding Degrees
        /// </summary>
        /// <param name="first">
        /// Value in radians
        /// </param>
        /// <returns>
        /// Result in degrees
        /// </returns>
        public double CalculateTwo(double first)
        {
            return first * (180 / Math.PI);
        }
    }
}
