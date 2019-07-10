﻿using System;

namespace Calculator.FactoryTwo.Operations
{
   public class Degrees : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return first * (180 / Math.PI);
        }
    }
}
