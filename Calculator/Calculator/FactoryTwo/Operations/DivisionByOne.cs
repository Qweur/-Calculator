namespace Calculator.FactoryTwo.Operations
{
    public class DivisionByOne : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return 1 / first;
        }
    }
}
