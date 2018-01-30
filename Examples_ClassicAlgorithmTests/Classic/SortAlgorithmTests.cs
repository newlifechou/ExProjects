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
        public void BubbleSortNormalTest()
        {
            int[] data = { 3, 6, 4, 2, 1, 7, 4 };
            int[] dataSorted = { 1, 2, 3, 4, 4, 6, 7 };
            new SortAlgorithm().BubbleSortNormal(data);
            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(dataSorted[i], data[i]);
            }

        }

        [TestMethod()]
        public void BubbleSortBetterTest()
        {
            int[] data = { 3, 6, 4, 2, 1, 7, 4 };
            int[] dataSorted = { 1, 2, 3, 4, 4, 6, 7 };
            new SortAlgorithm().BubbleSortBetter(data);
            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(dataSorted[i], data[i]);
            }
        }

        [TestMethod()]
        public void InsertSortTest()
        {
            int[] data = { 3, 6, 4, 2, 1, 7, 4 };
            int[] dataSorted = { 1, 2, 3, 4, 4, 6, 7 };
            new SortAlgorithm().InsertSort(data);
            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(dataSorted[i], data[i]);
            }
        }

        [TestMethod()]
        public void InsertSortBetterTest()
        {
            int[] data = { 3, 6, 4, 2, 1, 7, 4 };
            int[] dataSorted = { 1, 2, 3, 4, 4, 6, 7 };
            new SortAlgorithm().InsertSortBetter(data);
            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(dataSorted[i], data[i]);
            }
        }

        [TestMethod()]
        public void ShellSortTest()
        {
            int[] data = { 3, 6, 4, 2, 1, 7, 4 };
            int[] dataSorted = { 1, 2, 3, 4, 4, 6, 7 };
            new SortAlgorithm().ShellSort(data);
            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(dataSorted[i], data[i]);
            }
        }

        [TestMethod()]
        public void DirectSelectTest()
        {
            int[] data = { 3, 6, 4, 2, 1, 7, 4 };
            int[] dataSorted = { 1, 2, 3, 4, 4, 6, 7 };
            new SortAlgorithm().DirectSelectSort(data);
            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(dataSorted[i], data[i]);
            }
        }
    }
}