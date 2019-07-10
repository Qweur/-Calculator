namespace Calculator.FactoryTwo.Operations
{
    class SquareRoot : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return first * first;
        }
    }
}