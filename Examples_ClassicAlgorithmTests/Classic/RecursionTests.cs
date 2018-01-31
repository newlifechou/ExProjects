using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examples_ClassicAlgorithm.Classic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.Classic.Tests
{
    [TestClass()]
    public class RecursionTests
    {
        [TestMethod()]
        public void FibTest()
        {
            Recursion t = new Recursion();
            Assert.AreEqual(1, t.Fib(2));
            Assert.AreEqual(1, t.Fib(2));
            Assert.AreEqual(2, t.Fib(3));
            Assert.AreEqual(3, t.Fib(4));
            Assert.AreEqual(5, t.Fib(5));
            Assert.AreEqual(8, t.Fib(6));

        }

        [TestMethod()]
        public void FTest()
        {
            Recursion t = new Recursion();
            Assert.AreEqual(1, t.Factorial(0));
            Assert.AreEqual(1, t.Factorial(1));
            Assert.AreEqual(2, t.Factorial(2));
            Assert.AreEqual(6, t.Factorial(3));
            Assert.AreEqual(24, t.Factorial(4));

        }

        [TestMethod()]
        public void SumAllTest()
        {
            Recursion t = new Recursion();
            Assert.AreEqual(0, t.SumAll(0));
            Assert.AreEqual(1, t.SumAll(1));
            Assert.AreEqual(3, t.SumAll(2));
            Assert.AreEqual(6, t.SumAll(3));
        }
    }
}