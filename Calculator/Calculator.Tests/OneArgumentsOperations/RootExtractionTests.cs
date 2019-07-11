using Calculator.OneArgumentsOperations;
using NUnit.Framework;
using System;

namespace Calculator.Tests.OneArgumentsOperations
{
    [TestFixture]
    public class RootExtractionTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new RootExtraction();
            var actual = calculator.CalculateTwo(65536);

            Assert.AreEqual(256, actual, 0.25);
            Assert.Throws<Exception>(code: () => calculator.CalculateTwo(-4));

        }
    }
}