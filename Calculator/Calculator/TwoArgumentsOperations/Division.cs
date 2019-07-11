using System;

namespace Calculator.TwoArgumentsOperations
{
    public class Division : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на 0");
            }

            return first / second;
        }

}
}
