namespace Calculator.FactoryOne.Operations
{
    class Division : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first / second;
        }
    }
}
