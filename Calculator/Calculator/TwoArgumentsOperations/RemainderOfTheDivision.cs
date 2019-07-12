namespace Calculator.TwoArgumentsOperations
{
    /// <summary>
    /// Count Remainder Of The Division
    /// </summary>
    public class RemainderOfTheDivision : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Finding Remainder Of The Division
        /// </summary>
        /// <param name="first">
        /// Value of the first parameter
        /// </param>
        /// <param name="second">
        /// Value of the second parameter
        /// </param>
        /// <returns>
        /// Return Remainder Of The Division
        /// </returns>
        public double Calculate(double first, double second)
        {
            return first % second;
        }
    }
}