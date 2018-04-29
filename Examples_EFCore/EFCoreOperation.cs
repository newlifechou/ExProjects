﻿using Examples_EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples_EFCore
{
    /// <summary>
    /// 这个例子用来演示EF Core对Sql Server的访问
    /// EF Core version 2.0
    /// </summary>
    public static class EFCoreOperation
    {
        public static void Post()
        {
            using (var db = new SchoolContext())
            {
                var teacher = new Teacher() { Name = "Tompson George" };
                var student1 = new Student() { Name = "Jack Paul", Teacher = teacher };
                var student2 = new Student() { Name = "Peter Jackson", Teacher = teacher };
                var student3 = new Student() { Name = "Winters Dick", Teacher = teacher };
                var student4 = new Student() { Name = "David Green", Teacher = teacher };
                db.Teachers.Add(teacher);
                db.Students.AddRange(student1, student2, student3, student4);
                int result = db.SaveChangesAsync().Result;
                Console.WriteLine($"Insert done with {result} changed");
            }
        }

        public static void Get()
        {
            using (var db = new SchoolContext())
            {
                foreach (var item in db.Students.Include("Teacher"))
                {
                    Console.WriteLine($"{item.Id}->{item.Name}->{item.Teacher?.Name}");
                }
            }
        }
    }
}
