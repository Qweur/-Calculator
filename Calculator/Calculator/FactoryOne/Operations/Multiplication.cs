namespace Calculator.FactoryOne.Operations
{
    public class Multiplication : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first* second;
        }
    }
}
