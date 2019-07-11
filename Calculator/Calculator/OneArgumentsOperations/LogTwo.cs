using System;

namespace Calculator.OneArgumentsOperations
{
    /// <summary>
    /// Count LogTwo
    /// </summary>
    public class LogTwo : IOneArgumentsCalculator
    {
        /// <summary>
        /// Finding LogTwo
        /// </summary>
        /// <param name="first">
        /// Value of the parameter
        /// </param>
        /// <returns>
        /// LogTwo results
        /// </returns>
        public double CalculateTwo(double first)
        {
            return Math.Log(first,2);
        }
    }
}
