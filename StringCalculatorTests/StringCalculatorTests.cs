using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorKata;

namespace StringCalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddEmptyString_Return0()
        {
            int result = CalculatorKata.Add("");
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void AddOne_Return1()
        {
            int result = CalculatorKata.Add("");
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void AddThree_Return3()
        {
            int result = CalculatorKata.Add("");
            Assert.AreEqual(3, result);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void AddCustomDelimiter_ThrowException()
        {
            int result = CalculatorKata.Add("//3\n3");
            Assert.AreEqual(6, result);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void AddCustomDelimiter_Return6()
        {
            int result = CalculatorKata.Add("//;\n1;2;3");
            Assert.AreEqual(6, result);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void AddCustomDelimiter_ThrowsException()
        {
            int result = CalculatorKata.Add("//;\n1-2-3");
            Assert.AreEqual(6, result);
        }
    }
}