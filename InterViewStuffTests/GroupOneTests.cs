using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterViewStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewStuff.Tests
{
    [TestClass()]
    public class GroupOneTests
    {
        private GroupOne gg;

        [TestInitialize]
        public void ConstructIt()
        {
            gg = new GroupOne();
        }

        [TestMethod()]
        public void OneTest()
        {
            int result = 0;
            for (int i = 0; i < 10000; i++)
            {
                result = gg.One(1000000);
            }
            Assert.AreEqual(-500000, result);
        }

        [TestMethod()]
        public void TwoTest()
        {
            int result = 0;
            for (int i = 0; i < 10000; i++)
            {
                result = gg.Two(1000000);
            }
            Assert.AreEqual(-500000, result);
        }
    }
}