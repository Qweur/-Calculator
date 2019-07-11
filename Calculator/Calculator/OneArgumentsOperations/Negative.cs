namespace Calculator.OneArgumentsOperations
{
   public class Negative : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return first * -1;
        }
    }
}
