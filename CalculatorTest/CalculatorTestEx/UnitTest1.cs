using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorTestEx;

namespace CalculatorTestEx
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator calculator = new Calculator();

            var result = calculator.Add(10, 10);
            Assert.AreEqual(20, result);

            var result2 = calculator.Subtract(30, 10);
            Assert.AreEqual(20, result);

            var result3 = calculator.Multiple(5, 2);
            Assert.AreEqual(10, result);

            var result4 = calculator.Divide(10, 2);
            Assert.AreEqual(5, result);



        }
    }
}
