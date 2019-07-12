using Calculator.OneArgumentsOperations;
using NUnit.Framework;
using System;

namespace Calculator.Tests.OneArgumentsOperations
{
    [TestFixture]
    public class DivisionByOneTests
    {
        [TestCase(2, 0.5)]
        [TestCase(6, 0.166)]
        [TestCase(8, 0.125)]
        public void CalculateTest(
            double first,
            double expected)
        {
            var calculator = new DivisionByOne();
            var actualResult = calculator.CalculateTwo(first);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
        [Test]
        public void WrongAnswer()
        {
            var calculator = new DivisionByOne();
            Assert.Throws<Exception>(code: () => calculator.CalculateTwo(0));
        }

    }
}