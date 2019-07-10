using NUnit.Framework;


namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class DivisionByOneTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Calculator.FactoryTwo.Operations.DivisionByOne();
            var actual = calculator.CalculateTwo(1000);

            Assert.AreEqual(0.001, actual, 0.01);
        }
    }
}