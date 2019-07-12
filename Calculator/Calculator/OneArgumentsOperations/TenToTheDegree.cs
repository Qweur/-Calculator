using System;

namespace Calculator.OneArgumentsOperations
{
    /// <summary>
    /// Count TenToTheDegree
    /// </summary>
    public class TenToTheDegree : IOneArgumentsCalculator
    {
        /// <summary>
        /// Finding TenToTheDegree
        /// </summary>
        /// <param name="first">
        /// Value of the parameter
        /// </param>
        /// <returns>
        /// TenToTheDegree results
        /// </returns>
        public double CalculateTwo(double first)
        {
            return Math.Pow(10, first);
        }
    }
}