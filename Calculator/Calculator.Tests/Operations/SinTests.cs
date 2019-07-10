using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class SinTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Calculator.FactoryTwo.Operations.Sin();
            var actual = calculator.CalculateTwo(150);

            Assert.AreEqual(-0.5, actual, 0.25);
        }
    }
}