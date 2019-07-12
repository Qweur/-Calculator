using System;

namespace Calculator.OneArgumentsOperations
{
    /// <summary>
    /// Count LnX
    /// </summary>
    public class LnX : IOneArgumentsCalculator
    {
        /// <summary>
        /// Finding LnX
        /// </summary>
        /// <param name="first">
        /// Value of the parameter
        /// </param>
        /// <returns>
        /// LnX results
        /// </returns>
        public double CalculateTwo(double first)
        {
            if (first < 0)
            {
                throw new Exception("Не должно быть меньше 0");
            }
            return Math.Log(first, Math.E);
        }
    }
}
