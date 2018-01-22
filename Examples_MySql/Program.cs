using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Examples_MySql
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"server=localhost;database=myshop;uid=root;pwd=newlifechou";
            MySqlConnection con = new MySqlConnection(conStr);
            try
            {
                con.Open();
                Console.WriteLine("打开mysql连接成功");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }


            Console.Read();
        }
    }
}
