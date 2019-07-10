using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class RootExtractionTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Calculator.FactoryTwo.Operations.RootExtraction();
            var actual = calculator.CalculateTwo(65536);

            Assert.AreEqual(256, actual, 0.25);
        }
    }
}