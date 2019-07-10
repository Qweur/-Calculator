using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class MaxTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Calculator.FactoryOne.Operations.Max();
            var actual = calculator.Calculate(150, 20);

            Assert.AreEqual(150, actual, 0.01);
        }
    }
}
