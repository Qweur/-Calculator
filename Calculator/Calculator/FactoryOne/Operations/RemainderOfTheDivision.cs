namespace Calculator.FactoryOne.Operations
{
    public class RemainderOfTheDivision : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first % second;
        }
    }
}
