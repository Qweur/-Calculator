using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    class RemainderOfTheDivisionTests
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
