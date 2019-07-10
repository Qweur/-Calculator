namespace Calculator.FactoryTwo.Operations
{
    class Negative : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return first * -1;
        }
    }
}
