using System;
using Calculator.TwoArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsOperations
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Division();
            var actual = calculator.Calculate(10, 5);

            Assert.AreEqual(2, actual, 0.01);
            Assert.Throws<Exception>(code: () => calculator.Calculate(1, 0));
        }
    }
}