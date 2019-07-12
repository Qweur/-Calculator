using Calculator.OneArgumentsOperations;
using NUnit.Framework;
using System;

namespace Calculator.Tests.OneArgumentsOperations
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
            var calculator = new LnX();
            var actualResult = calculator.CalculateTwo(first);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
        [Test]
        public void WrongAnswer()
        {
            var calculator = new LnX();
            Assert.Throws<Exception>(code: () => calculator.CalculateTwo(-1));
        }

    }
}