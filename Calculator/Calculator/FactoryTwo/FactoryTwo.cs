using System;
using Calculator._10;
using Calculator.FactoryTwo.Operations;

namespace Calculator.FactoryTwo
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
                case "Sin":
                    return new Sin();
                case "Arcsin":
                    return new Arcsin();
                case "CTan":
                    return new CTan();
                case "DivisionByOne":
                    return new DivisionByOne();
                case "LnX":
                    return new LnX();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}