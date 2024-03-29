﻿using System;

namespace Calculator.OneArgumentsOperations
{
    /// <summary>
    /// Factory for a one argument
    /// </summary>
    public static class OneArgumentCalculatorsFactory
    {
        /// <summary>
        /// FactoryTwo
        /// </summary>
        /// <param name="name">
        /// Operation name
        /// </param>
        /// <returns>
        /// Create a new calculator with the desired action
        /// </returns>
        public static IOneArgumentsCalculator CreateCalculator(string name)
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
                case "LogTwo":
                    return new LogTwo();
                case "Cos":
                    return new Cos();
                case "Exponent":
                    return new Exponent();
                case "TenToTheDegree":
                    return new TenToTheDegree();
                case "Negative":
                    return new Negative();
                case "Degrees":
                    return new Degrees();
                case "Radians":
                    return new Radians();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}