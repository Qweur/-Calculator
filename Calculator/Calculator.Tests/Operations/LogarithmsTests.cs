using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    class LogarithmsTests
    {
        [TestFixture]
        public class AdditionTests
        {
            [Test]
            public void CalculateTest()
            {
                var calculator = new Calculator.FactoryOne.Operations.Logarithms();
                var actual = calculator.Calculate(5, 5);

                Assert.AreEqual(1, actual, 0.01);
            }
        }
    }
}
