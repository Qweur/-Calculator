using System;

namespace Calculator
{
    public static class FactoryTwo
    {
        public static IOneArgumentsCalculator CalculateTwo(string name)
        {

            switch (name)
            {
                case "Root_extraction":
                    return new RootExtraction();
                case "Square_root":
                    return new SquareRoot();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}