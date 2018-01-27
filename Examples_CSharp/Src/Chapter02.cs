using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_CSharp.Src
{
    #region 自定义委托类型
    //凡是可以定义类的地方都可以定义委托类型
    delegate void StringProcessor(string input);

    #endregion
    class One
    {
        public static void StaticMethod(string msg)
        {

        }
    }


    /// <summary>
    /// C# 1
    /// </summary>
    class Chapter02
    {










        //字段风格的事件，可以看成是属性，实际在调用方法。
        public event StringProcessor OnStringProcessor;

        public void UseDelegateInstance()
        {
            //委托的目的是间接操作
            StringProcessor proc1, proc2;
            proc1 = new StringProcessor(One.StaticMethod);
            proc2 = new StringProcessor(InstanceMethod);

            proc1.Invoke("world");
            proc2("hello");
        }

        private void InstanceMethod(string msg)
        {

        }
    }

    /// <summary>
    /// 测试协变和抗变
    /// </summary>
    class TestVariance
    {
        public delegate void Bite(Dog d);
        public delegate void Feed<T>(T target);
        public void One()
        {
            Bite1(new Dog());
            Bite2(new Dog());

            Dog result = Buy1();
            Animal result2 = Buy1();

            Animal[] animals = new Dog[10];

            Bite b1 = Bite1;
            Bite b2 = Bite2;
            Feed<Dog> f1 = Bite1;
            Feed<Animal> f2 = Bite2;
            Feed<Dog> f3 = Bite2;
        }
        private void Bite1(Dog g) { }
        private void Bite2(Animal a) { }

        private Dog Buy1() { return null; }
        private Animal Buy2() { return null; }

    }

    class Animal { }
    class Dog : Animal { }

    /// <summary>
    /// 测试接口的显式实现
    /// </summary>
    class MyPerson : ICloneable
    {
        //public object Clone()
        //{
        //    throw new NotImplementedException();
        //}

        public MyPerson Clone()
        {
            throw new NotImplementedException();
        }

        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }

    }


}
