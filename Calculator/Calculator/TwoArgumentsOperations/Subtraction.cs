namespace Calculator.TwoArgumentsOperations
{
    /// <summary>
    /// Count Subtraction
    /// </summary>
    public class Subtraction : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Finding Subtraction
        /// </summary>
        /// <param name="first">
        /// Number raised to the power
        /// </param>
        /// <param name="second">
        /// The degree of the number divided by 1
        /// </param>
        /// <returns>
        /// Subtraction results
        /// </returns>
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}
