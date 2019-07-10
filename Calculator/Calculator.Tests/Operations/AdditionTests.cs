using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Calculator.FactoryOne.Operations.Addition();
            var actual = calculator.Calculate(3, 2);

            Assert.AreEqual(5,actual ,0.01);
        }
    }
}
