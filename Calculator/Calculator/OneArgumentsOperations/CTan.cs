using System;

namespace Calculator.OneArgumentsOperations
{
    /// <summary>
    /// Count CTan
    /// </summary>
    public class CTan : IOneArgumentsCalculator
    {
        /// <summary>
        /// Finding CTan
        /// </summary>
        /// <param name="first">
        /// Value of the parameter
        /// </param>
        /// <returns>
        /// CTan results
        /// </returns>
        public double CalculateTwo(double first)
        {
            return 1/ Math.Tan(first);
        }
    }
}
