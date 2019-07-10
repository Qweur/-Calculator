using System;
using Calculator._10;
using Calculator.FactoryOne.Operations;

namespace Calculator.FactoryOne
{
   public static class Factory
    {
        public static ITwoArgumentsCalculator Calculate(string name)
        {

            switch (name)
            {
                case "Addition":
                    return new Addition();

                case "Subtraction":
                    return new Subtraction();

                case "Multiplication":
                    return new Multiplication();

                case "Division":
                    return new Division();
                case "Logarithms":
                    return new Logarithms();
                case "RemainderOfTheDivision":
                    return new RemainderOfTheDivision();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
