using System;
using System.Collections.Generic;
using System.Text;

namespace Examples_EFCore.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Student> Students { get; set; }
    }
}
