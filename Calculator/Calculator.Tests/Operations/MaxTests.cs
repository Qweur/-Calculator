using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class MaxTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Calculator.FactoryOne.Operations.RemainderOfTheDivision();
            var actual = calculator.Calculate(80, 56);

            Assert.AreEqual(24, actual, 0.01);
        }
    }
}
