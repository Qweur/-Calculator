using System;

namespace Calculator.TwoArgumentsOperations
{
    /// <summary>
    /// Count Division
    /// </summary>
    public class Division : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Finding Division
        /// </summary>
        /// <param name="first">
        /// Value of the first parameter
        /// </param>
        /// <param name="second">
        /// Value of the second parameter
        /// </param>
        /// <returns>
        /// Return Division
        /// </returns>
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на 0");
            }

            return first / second;
        }

}
}
