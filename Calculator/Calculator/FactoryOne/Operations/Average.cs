namespace Calculator.FactoryOne.Operations
{
    public class Average : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return (first * second)/2;
        }
    }
}