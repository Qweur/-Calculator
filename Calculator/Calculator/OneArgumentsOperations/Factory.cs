﻿using System;

namespace Calculator.OneArgumentsOperations
{
   public static class Factory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string name)
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
                case "Max":
                    return new Max();
                case "GeometricMean":
                    return new GeometricMean();
                case "Min":
                    return new Min();
                case "Average":
                    return new Average();
                case "Exponentiation":
                    return new Exponentiation();
                case "Root":
                    return new Root();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}