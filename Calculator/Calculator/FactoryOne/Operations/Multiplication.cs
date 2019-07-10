namespace Calculator
{
    class Multiplication : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first* second;
        }
    }
}
