using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Calculator.FactoryOne.Operations.Division();
            var actual = calculator.Calculate(10, 5);

            Assert.AreEqual(2, actual, 0.01);
        }
    }
}