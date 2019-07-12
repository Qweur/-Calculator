using System;

namespace Calculator.OneArgumentsOperations
{
    /// <summary>
    /// Count arcsin
    /// </summary>
    public class Arcsin : IOneArgumentsCalculator
    {
        /// <summary>
        /// Finding arcsin
        /// </summary>
        /// <param name="first">
        /// Value arcsin
        /// </param>
        /// <returns>
        /// arcsin results
        /// </returns>
        public double CalculateTwo(double first)
        {
            if (first > 1 || first < -1)
            {
                throw new Exception("Выход за пределы значения");
            }
            return Math.Asin(first);
        }
    }
}
