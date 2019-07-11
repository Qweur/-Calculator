namespace Calculator.TwoArgumentsOperations
{
    public class RemainderOfTheDivision : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first % second;
        }
    }
}
