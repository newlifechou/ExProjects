using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Sqlite
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sql = new SqliteOperation();
            //sql.Connect();
            //sql.DeleteAll();
            //sql.Insert();

            for (int i = 0; i < 100; i++)
            {
                EFOperation.Insert("Person "+i);
            }


            Console.Read();
        }
    }
}
