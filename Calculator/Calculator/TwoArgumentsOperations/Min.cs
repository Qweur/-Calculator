using System;

namespace Calculator.TwoArgumentsOperations
{/// <summary>
/// Finding the minimum
/// </summary>
    public class Min : ITwoArgumentsCalculator
    {/// <summary>
     /// 
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