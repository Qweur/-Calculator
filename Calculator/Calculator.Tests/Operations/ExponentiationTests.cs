﻿using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]

   public class ExponentiationTests
    {
        [TestCase(3, 3, 27)]
        [TestCase(6, 5, 7776)]
        [TestCase(4, 1, 4)]

        public void CalculateTest(
   double first,
   double second,
   double expected)
        { 
            var calculator = new Calculator.FactoryOne.Operations.Exponentiation();
            var actualResult = calculator.Calculate(first, second);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
