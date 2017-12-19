using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Array.Tests
{
    [TestClass()]
    public class NumberMethodTests
    {
        [TestMethod()]
        public void ThreeEqualTest1()
        {
            int a = 3, b = 3, c = 3;
            NumberMethod test = new NumberMethod();
            Assert.IsTrue(test.ThreeEqual(a, b, c));
        }
        [TestMethod()]
        public void ThreeEqualTest2()
        {
            int a = 3, b = 3, c = 2;
            NumberMethod test = new NumberMethod();
            Assert.IsFalse(test.ThreeEqual(a, b, c));
        }
        [TestMethod()]
        public void ThreeEqualTest3()
        {
            int a = 2, b = 3, c = 3;
            NumberMethod test = new NumberMethod();
            Assert.IsFalse(test.ThreeEqual(a, b, c));
        }
        [TestMethod()]
        public void ThreeEqualTest4()
        {
            int a = 3, b = 2, c = 3;
            NumberMethod test = new NumberMethod();
            Assert.IsFalse(test.ThreeEqual(a, b, c));
        }
        [TestMethod()]
        public void ThreeEqualTest5()
        {
            int a = 1, b = 2, c = 3;
            NumberMethod test = new NumberMethod();
            Assert.IsFalse(test.ThreeEqual(a, b, c));
        }

        [TestMethod()]
        public void BetweenZeroAndOneTest()
        {
            double a = 0.5, b = 0.6;
            NumberMethod test = new NumberMethod();
            Assert.IsTrue(test.BetweenZeroAndOne(a, b));
        }

        [TestMethod()]
        public void ToBinaryTest()
        {
            int a = 6;
            NumberMethod test = new NumberMethod();
            Assert.AreEqual("110", test.ToBinary(a));
        }
        [TestMethod()]
        public void ToBinaryTest2()
        {
            int a = 7;
            NumberMethod test = new NumberMethod();
            Assert.AreEqual("111", test.ToBinary(a));
        }

    }
}