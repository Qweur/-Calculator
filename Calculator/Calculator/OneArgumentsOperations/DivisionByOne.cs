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
            return 1 / first;
        }
    }
}
