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
    public class SortAlgorithmTests
    {
        [TestMethod()]
        public void BubbleSortTest()
        {
            int[] data = { 3, 6, 4, 2, 1, 7, 4 };
            int[] dataSorted = { 1, 2, 3, 4, 4, 6, 7 };
            new SortAlgorithm().BubbleSortNormal(data);
            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(dataSorted[i], data[i]);
            }

        }
    }
}