using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Sqlite
{
    static class EFOperation
    {
        public static void Insert(string name)
        {
            using (var context=new PersonContext())
            {
                context.Persons.Add(new Person { Id = Guid.NewGuid(), Name = name });
                context.SaveChanges();
                Console.WriteLine("Insert Done");
            }
        }
    }
}
