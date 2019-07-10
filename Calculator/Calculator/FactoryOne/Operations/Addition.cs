namespace Calculator.FactoryOne.Operations
{
    class Addition : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
