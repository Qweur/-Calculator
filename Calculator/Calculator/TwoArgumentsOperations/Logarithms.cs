using System;

namespace Calculator.TwoArgumentsOperations
{
    /// <summary>
    /// Count Logarithms
    /// </summary>
    public class Logarithms : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Finding Logarithms
        /// </summary>
        /// <param name="first">
        /// Value of the first parameter
        /// </param>
        /// <param name="second">
        /// Value of the second parameter
        /// </param>
        /// <returns>
        /// Return Logarithms
        /// </returns>
        public double Calculate(double first, double second)
        {
            if (first < 0 || second == 1 || second < 0)
            {
                throw new Exception("Не верные данные");
            }
            return Math.Log(first, second);
        }
    }
}