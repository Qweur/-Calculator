using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class LogTwo
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Calculator.FactoryTwo.Operations.LogTwo();
            var actual = calculator.CalculateTwo(5);

            Assert.AreEqual(2.3, actual, 0.25);
        }
    }
}
