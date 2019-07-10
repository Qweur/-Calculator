using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class CTanTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Calculator.FactoryTwo.Operations.CTan();
            var actual = calculator.CalculateTwo(500);

            Assert.AreEqual(1.88, actual, 0.01);
        }
    }
}
