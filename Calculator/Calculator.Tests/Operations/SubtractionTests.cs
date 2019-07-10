using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class SubtractionTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Calculator.FactoryOne.Operations.Subtraction();
            var actual = calculator.Calculate(10, 5);

            Assert.AreEqual(5, actual, 0.01);
        }
    }
}
