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
    }
}