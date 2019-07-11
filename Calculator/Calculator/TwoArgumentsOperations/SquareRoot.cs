namespace Calculator.TwoArgumentsOperations
{
    public class SquareRoot : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return first * first;
        }
    }
}