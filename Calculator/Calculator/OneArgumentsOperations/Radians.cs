using System;

namespace Calculator.OneArgumentsOperations
{
    /// <summary>
    /// Count Radians
    /// </summary>
    public class Radians : IOneArgumentsCalculator
    {
        /// <summary>
        /// Finding Radians
        /// </summary>
        /// <param name="first">
        /// Value in degrees
        /// </param>
        /// <returns>
        /// Result in radians
        /// </returns>
        public double CalculateTwo(double first)
        {
            return first * (Math.PI / 180);
        }
    }
}
