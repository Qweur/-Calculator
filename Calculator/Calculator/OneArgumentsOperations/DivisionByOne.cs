namespace Calculator.OneArgumentsOperations
{
    public class DivisionByOne : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return 1 / first;
        }
    }
}
