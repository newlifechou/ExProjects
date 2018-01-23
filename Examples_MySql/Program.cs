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

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from customer";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0]);
                    Console.WriteLine(dr[1]);
                    Console.WriteLine(dr[2]);


                }
                dr.Close();

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
