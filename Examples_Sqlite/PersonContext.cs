using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Sqlite
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("person")
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
