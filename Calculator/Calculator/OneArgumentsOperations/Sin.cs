using System;

namespace Calculator.OneArgumentsOperations
{
    /// <summary>
    /// Count Sin
    /// </summary>
    public class Sin : IOneArgumentsCalculator
    {
        /// <summary>
        /// Finding Sin
        /// </summary>
        /// <param name="first">
        /// Value of the parameter
        /// </param>
        /// <returns>
        /// Sin results
        /// </returns>
        public double CalculateTwo(double first)
        {
            return Math.Sin(first);
        }
    }
}
