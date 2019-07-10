namespace Calculator.FactoryOne.Operations
{
    public class Addition : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
