using System;

namespace Calculator.OneArgumentsOperations
{
    /// <summary>
    /// Count Exponent
    /// </summary>
    public class Exponent : IOneArgumentsCalculator
    {
        /// <summary>
        /// Finding Exponent
        /// </summary>
        /// <param name="first">
        /// Value of the parameter
        /// </param>
        /// <returns>
        /// Exp results
        /// </returns>
        public double CalculateTwo(double first)
        {
            return Math.Exp(first);
        }
    }
}
