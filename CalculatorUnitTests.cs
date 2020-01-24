using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
namespace CalculatorTests
{
    /// <summary>
    /// this is a test class to perform unit tests on different methods in calculator class(SUT)
    /// </summary>
    [TestClass]
    public class CalculatorUnitTests
    {
        /// <summary>
        /// test method for testing Add method of SUT
        /// </summary>
        [TestMethod]
        public void TestingAdd()
        {
            Calculator a1 = new Calculator();
            double n1 = -23.452;
            double n2 = -25;
            double expected = n1 + n2;
            double actual = a1.Add(n1, n2);
            Assert.AreEqual(actual, expected, 0, "result is wrong");

        }
        [TestMethod]
        public void TestingAdd1()
        {
            Calculator a1 = new Calculator();
            double m1 = Double.MaxValue;
            double m2 = 25;
            Assert.ThrowsException<System.OverflowException>(() => a1.Add(m1, m2));
        }
        [TestMethod]
        public void TestingAdd2()
        {
            Calculator a1 = new Calculator();
            double o1 = 23;
            double o2 = Double.MaxValue;
            Assert.ThrowsException<System.OverflowException>(() => a1.Add(o1, o2));
        }
        [TestMethod]
        public void TestingAdd3()
        {
            Calculator a1 = new Calculator();
            double p1 = Double.MaxValue;
            double p2 = Double.MaxValue;
            Assert.ThrowsException<System.OverflowException>(() => a1.Add(p1, p2));
        }
        /// <summary>
        /// test method for testing Sub method of SUT
        /// </summary>
        [TestMethod]
        public void TestingSub()
        {
            Calculator a1 = new Calculator();
            double n1 = -23.452;
            double n2 = -25;
            double expected = n1 - n2;
            double actual = a1.Sub(n1, n2);
            Assert.AreEqual(actual, expected, 0, "result is wrong");

        }
        [TestMethod]
        public void TestingSub1()
        {
            Calculator a1 = new Calculator();
            double o1 = Double.MinValue;
            double o2 = Double.MaxValue;
            Assert.ThrowsException<System.OverflowException>(() => a1.Sub(o1, o2));
        }
        [TestMethod]
        public void TestingSub2()
        {
            Calculator a1 = new Calculator();
            double p1 = Double.MaxValue;
            double p2 = Double.MinValue;
            Assert.ThrowsException<System.OverflowException>(() => a1.Sub(p1, p2));

        }
        /// <summary>
        /// test method for testing Mul method of SUT
        /// </summary>
        [TestMethod]
        public void TestingMul()
        {
            double n1 = -23.452;
            double n2 = -25;
            double expected = n1 * n2;
            Calculator a1 = new Calculator();
            double actual = a1.Mul(n1, n2);
            Assert.AreEqual(actual, expected, 0, "result is wrong");
           
        }
        [TestMethod]
        public void TestingMul1()
        {
            Calculator a1 = new Calculator();
            double n1 = Double.MaxValue;
            double n2 = 2;
            Assert.ThrowsException<System.OverflowException>(() => a1.Mul(n1, n2));
        }
        [TestMethod]
        public void TestingMul2()
        {
            Calculator a1 = new Calculator();
            double n2 = Double.MaxValue;
            double n1 = 2;
            Assert.ThrowsException<System.OverflowException>(() => a1.Mul(n1, n2));
        }
        [TestMethod]
        public void TestingDiv()
        {
            Calculator a1 = new Calculator();
            double n1 = 23;
            double n2 = 25;
            double expected = n1 / n2;
            double actual = a1.Div(n1, n2);
            Assert.AreEqual(actual, expected, 0, "result is wrong");
        }

        [TestMethod]
        public void TestingDiv1()
        {
            double n1 = -23.452;
            double n2 = 0;
            Calculator a1 = new Calculator();
            Assert.ThrowsException<System.DivideByZeroException>(() => a1.Div(n1,n2));
            
        }

    }
}
