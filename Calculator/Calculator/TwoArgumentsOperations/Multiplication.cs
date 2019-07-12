namespace Calculator.TwoArgumentsOperations
{
    /// <summary>
    /// Count Multiplication
    /// </summary>
    public class Multiplication : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Finding Multiplication
        /// </summary>
        /// <param name="first">
        /// Value of the first parameter
        /// </param>
        /// <param name="second">
        /// Value of the second parameter
        /// </param>
        /// <returns>
        /// Return Multiplication
        /// </returns>
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}