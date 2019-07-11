namespace Calculator.OneArgumentsOperations
{
    /// <summary>
    /// Count SquareRoot
    /// </summary>
    public class SquareRoot : IOneArgumentsCalculator
    {
        /// <summary>
        /// Finding SquareRoot
        /// </summary>
        /// <param name="first">
        /// Value of the parameter
        /// </param>
        /// <returns>
        /// SquareRoot results
        /// </returns>
        public double CalculateTwo(double first)
        {
            return first * first;
        }
    }
}