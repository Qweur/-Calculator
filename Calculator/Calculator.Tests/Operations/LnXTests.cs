using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class LnXTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Calculator.FactoryTwo.Operations.LnX();
            var actual = calculator.CalculateTwo(50);

            Assert.AreEqual(3.91, actual, 0.01);
        }
    }
}
