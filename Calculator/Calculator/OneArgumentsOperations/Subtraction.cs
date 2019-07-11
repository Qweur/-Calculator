namespace Calculator.OneArgumentsOperations
{
   public class Subtraction : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}
