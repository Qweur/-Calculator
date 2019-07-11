using System;

namespace Calculator.TwoArgumentsOperations
{
    /// <summary>
    /// Count Maximum
    /// </summary>
    public class Max : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Finding Maximum
        /// </summary>
        /// <param name="first">
        /// Value of the first parameter
        /// </param>
        /// <param name="second">
        /// Value of the second parameter
        /// </param>
        /// <returns>
        /// Return Maximum
        /// </returns>
        public double Calculate(double first, double second)
        {
            return Math.Max(first,second);
        }
    }
}
