namespace Calculator.TwoArgumentsOperations
{
    /// <summary>
    /// Count Addition
    /// </summary>
    public class Addition : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Finding Addition
        /// </summary>
        /// <param name="first">
        /// Value of the first parameter
        /// </param>
        /// <param name="second">
        /// Value of the second parameter
        /// </param>
        /// <returns>
        /// Return Addition
        /// </returns>
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
