namespace Calculator.TwoArgumentsOperations
{
   public class Negative : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return first * -1;
        }
    }
}
