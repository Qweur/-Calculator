using System;

namespace Calculator.OneArgumentsOperations
{
    /// <summary>
    /// Count DivisionByOne
    /// </summary>
    public class DivisionByOne : IOneArgumentsCalculator
    {
        /// <summary>
        /// Finding DivisionByOne
        /// </summary>
        /// <param name="first">
        /// Value of the parameter
        /// </param>
        /// <returns>
        /// DivisionByOne results
        /// </returns>
        public double CalculateTwo(double first)
        {
            if (first == 0)
            {
                throw new Exception("Деление на 0");
            }
            return 1 / first;
        }
    }
}
