using System;
using System.Collections.Generic;
using System.Text;

namespace Examples_EFCore.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
