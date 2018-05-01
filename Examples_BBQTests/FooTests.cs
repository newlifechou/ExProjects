using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examples_BBQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Examples_BBQ.Tests
{
    [TestClass()]
    public class FooTests
    {
        /// <summary>
        /// 这是普通测试方法,但是编写起来比较麻烦
        /// </summary>
        [TestMethod()]
        public void DoTest()
        {
            var fakelog = new FakeLog();
            var foo = new Foo(fakelog);
            foo.Do();
            Assert.AreEqual("Finish A", fakelog.Log);
        }


        /// <summary>
        /// 利用Moq隔离框架来做
        /// Nuget Moq引用类库
        /// </summary>
        [TestMethod]
        public void DoTest2()
        {
            var fakelog = new Mock<ILog>();
            var foo = new Foo(fakelog.Object);
            foo.Do();
            //stub
            fakelog.Setup(log => log.Read()).Returns("fuck");

            //mock
            fakelog.Verify(log => log.Write("Finish A"));
        }



    }
}