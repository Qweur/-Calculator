using System;

namespace Calculator.TwoArgumentsOperations
{/// <summary>
 /// Count Exponentiation
 /// </summary>
    public class Exponentiation : ITwoArgumentsCalculator
    {/// <summary>
     /// Finding Exponentiation
     /// </summary>
     /// <param name="first">
     /// Number raised to the power
     /// </param>
     /// <param name="second">
     /// Degree of
     /// </param>
     /// <returns>
     /// Exponentiation results
     /// </returns>
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}
