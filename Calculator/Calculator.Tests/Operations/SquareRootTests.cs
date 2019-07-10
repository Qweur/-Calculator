using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class SquareRootTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Calculator.FactoryTwo.Operations.SquareRoot();
            var actual = calculator.CalculateTwo(36);

            Assert.AreEqual(1296, actual, 0.25);
        }
    }
}
