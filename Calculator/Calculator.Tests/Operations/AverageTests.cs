﻿using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]

   public class AverageTests
    {
        [TestCase(-4, -5, 10)]
        [TestCase(7, 8, 28)]
        [TestCase(-5, 6, -15)]

        public void CalculateTest(
   double first,
   double second,
   double expected)
        {
            var calculator = new Calculator.FactoryOne.Operations.Average();
            var actualResult = calculator.Calculate(first, second);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
