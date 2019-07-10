﻿using System;

namespace Calculator.FactoryTwo.Operations
{
    class CTan : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return 1/ Math.Tan(first);
        }
    }
}
