﻿using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class LnXTests
    {
        [TestCase(2, 0.693)]
        [TestCase(20, 2.995)]
        [TestCase(95, 4.553)]
        public void CalculateTest(
            double first,
            double expected)
        {
            var calculator = new Calculator.FactoryTwo.Operations.LnX();
            var actualResult = calculator.CalculateTwo(first);
            Assert.AreEqual(expected, actualResult, 0.001);
        }

    }
}