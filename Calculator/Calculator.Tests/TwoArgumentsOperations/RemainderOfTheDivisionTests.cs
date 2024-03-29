﻿using Calculator.TwoArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsOperations
{
    [TestFixture]
    public class RemainderOfTheDivisionTests
    {
        [TestCase(5, 3, 2)]
        [TestCase(9, 4, 1)]
        [TestCase(10, 7, 3)]
        public void CalculateTest(
            double first,
            double second,
            double expected)
        {
            var calculator = new RemainderOfTheDivision();
            var actualResult = calculator.Calculate(first, second);
            Assert.AreEqual(expected, actualResult, 0.001);
        }

    }
}
