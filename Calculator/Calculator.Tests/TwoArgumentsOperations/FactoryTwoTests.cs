﻿using System;
using Calculator.TwoArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsOperations
{
    [TestFixture]
    class FactoryTwoTests
    {
        [TestCase("Root_extraction", typeof(RootExtraction))]
        [TestCase("Square_root", typeof(SquareRoot))]
        [TestCase("Sin", typeof(Sin))]
        [TestCase("Arcsin", typeof(Arcsin))]
        [TestCase("CTan", typeof(CTan))]
        [TestCase("DivisionByOne", typeof(DivisionByOne))]
        [TestCase("LnX", typeof(LnX))]
        [TestCase("LogTwo", typeof(LogTwo))]
        [TestCase("Cos", typeof(Cos))]
        [TestCase("Exponent", typeof(Exponent))]
        [TestCase("TenToTheDegree", typeof(TenToTheDegree))]
        [TestCase("Negative", typeof(Negative))]
        [TestCase("Degrees", typeof(Degrees))]
        [TestCase("Radians", typeof(Radians))]
        public void CreateCalculateTest(string name, Type type)
        {
            var calculator = FactoryTwo.CreateCalculatorTwo(name);

            Assert.IsInstanceOf(type, calculator);

        }
    }
}
