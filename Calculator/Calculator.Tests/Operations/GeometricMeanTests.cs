using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class GeometricMeanTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Calculator.FactoryOne.Operations.GeometricMean();
            var actual = calculator.Calculate(5, 20);

            Assert.AreEqual(10, actual, 0.01);
        }
    }
}
