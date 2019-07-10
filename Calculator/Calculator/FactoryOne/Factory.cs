using System;

namespace Calculator
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

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
