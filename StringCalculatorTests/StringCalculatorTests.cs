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
    }
}