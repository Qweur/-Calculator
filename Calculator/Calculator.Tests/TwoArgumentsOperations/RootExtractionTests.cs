using Calculator.TwoArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsOperations
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
        }
    }
}