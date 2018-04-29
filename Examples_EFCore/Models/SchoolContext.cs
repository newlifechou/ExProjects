using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Examples_EFCore.Models;

namespace Examples_EFCore
{
    public class SchoolContext : DbContext
    {
        private readonly string conn_str ="server=192.168.15.115;database=VirtualSchool;uid=sa;pwd=newlifechou";
        public SchoolContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            //必须引用Microsoft.EntityFrameworkCore和Microsoft.EntityFrameworkCore.SqlServer的dll
            optionsBuilder.UseSqlServer(conn_str);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
