using System;

namespace Calculator.TwoArgumentsOperations
{/// <summary>
/// Count the minimum
/// </summary>
    public class Min : ITwoArgumentsCalculator
    {/// <summary>
     /// Finding the minimum
     /// </summary>
     /// <param name="first">
     /// Value of the first parameter
     /// </param>
     /// <param name="second">
     /// Value of the second parameter
     /// </param>
     /// <returns>
     /// Return Minimum Value
     /// </returns>
        public double Calculate(double first, double second)
        {
            return Math.Min(first, second);
        }
    }
}