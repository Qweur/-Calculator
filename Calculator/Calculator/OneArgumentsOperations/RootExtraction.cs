using System;

namespace Calculator.OneArgumentsOperations
{
    /// <summary>
    /// Count RootExtraction
    /// </summary>
    public class RootExtraction : IOneArgumentsCalculator
    {
        /// <summary>
        /// Finding RootExtraction
        /// </summary>
        /// <param name="first">
        /// Value of the parameter
        /// </param>
        /// <returns>
        /// RootExtraction results
        /// </returns>
        public double CalculateTwo(double first)
    {
        if (first < 0)
        {
            throw new Exception("Отрицательно");
        }
            return Math.Sqrt(first);
    }
    }
}