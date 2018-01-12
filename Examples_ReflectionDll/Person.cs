using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseReflectionDll
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Speak()
        {
            Console.WriteLine($"{Name}-{Age}");
        }
        public void Speak(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
