﻿using System;
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
                    return new TenToTheDegree();
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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}