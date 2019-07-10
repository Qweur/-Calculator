using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class ArcsinTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Calculator.FactoryTwo.Operations.Arcsin();
            var actual = calculator.CalculateTwo(220);

            Assert.AreEqual(0, actual, 0.25);
        }
    }
}