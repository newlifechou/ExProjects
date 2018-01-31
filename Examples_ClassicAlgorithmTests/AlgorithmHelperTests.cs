using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examples_ClassicAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.Tests
{
    [TestClass()]
    public class AlgorithmHelperTests
    {
        [TestMethod()]
        public void IsSortedTest()
        {
            int[] data1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] data2 = { 2, 3, 4, 5, 1, 2, 4, 8, 5 };
            Assert.IsTrue(AlgorithmHelper.IsSorted(data1));
            Assert.IsFalse(AlgorithmHelper.IsSorted(data2));

        }
    }
}