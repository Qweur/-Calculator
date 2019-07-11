namespace Calculator.OneArgumentsOperations
{/// <summary>
 /// Count Negative
 /// </summary>
    public class Negative : IOneArgumentsCalculator
    {/// <summary>
     /// Finding Negative
     /// </summary>
     /// <param name="first">
     /// Value of the parameter
     /// </param>
     /// <returns>
     /// Negative results
     /// </returns>
        public double CalculateTwo(double first)
        {
            return first * -1;
        }
    }
}
