﻿using NUnit.Framework;

namespace Calculator.Tests.Operations
{
  public  class RootTests
    {
        [TestCase(6, 2, 2.449)]
        [TestCase(3, -4, 0.759)]
        [TestCase(16, 8, 1.414)]

        public void CalculateTest(
double first,
double second,
double expected)
        {
            var calculator = new Calculator.FactoryOne.Operations.Root();
            var actualResult = calculator.Calculate(first, second);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}
