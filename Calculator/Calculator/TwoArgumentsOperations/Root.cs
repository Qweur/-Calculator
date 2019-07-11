using System;

namespace Calculator.TwoArgumentsOperations
{/// <summary>
 /// Count Root
 /// </summary>
    public class Root : ITwoArgumentsCalculator
    {/// <summary>
     /// Finding Root
     /// </summary>
     /// <param name="first">
     /// Number raised to the power
     /// </param>
     /// <param name="second">
     /// The degree of the number divided by 1
     /// </param>
     /// <returns>
     /// Root results
     /// </returns>
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, 1 / second);
        }
    }
}
