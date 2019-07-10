namespace Calculator.FactoryTwo.Operations
{
    public class SquareRoot : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return first * first;
        }
    }
}