using System;

namespace Calculator.OneArgumentsOperations
{/// <summary>
 /// Count cos
 /// </summary>
    public class Cos : IOneArgumentsCalculator
    {/// <summary>
     /// Finding cos
     /// </summary>
     /// <param name="first">
     /// Value cos
     /// </param>
     /// <returns>
     /// Cos results
     /// </returns>
        public double CalculateTwo(double first)
    {
        return Math.Cos(first);
    }

    }
}
