namespace Calculator.TwoArgumentsOperations
{
    /// <summary>
    /// Count arithmetic mean
    /// </summary>
    public class Average : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Finding arithmetic mean
        /// </summary>
        /// <param name="first">
        /// Value of the first parameter
        /// </param>
        /// <param name="second">
        /// Value of the second parameter
        /// </param>
        /// <returns>
        /// Return arithmetic mean
        /// </returns>
        public double Calculate(double first, double second)
        {
            return (first * second) / 2;
        }
    }
}