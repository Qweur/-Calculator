using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class Multiplication
    { 
            [Test]
            public void CalculateTest()
            {
                var calculator = new Calculator.FactoryOne.Operations.Multiplication();
                var actual = calculator.Calculate(10, 5);

                Assert.AreEqual(50, actual, 0.01);
            }
        }
}

