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
            if (first < 0)
            {
                throw new Exception("Не должно быть меньше 0");
            }
            return Math.Log(first,2);
        }
    }
}