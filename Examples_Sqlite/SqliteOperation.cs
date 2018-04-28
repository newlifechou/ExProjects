using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;
using System.Diagnostics;

namespace Examples_Sqlite
{
    /// <summary>
    /// 使用System.Data.Sqlite
    /// 直接操作ADO.NET对象的方式
    /// </summary>
    class SqliteOperation
    {
        /// <summary>
        /// 数据库文件如果不存在，就会创建这个数据库
        /// </summary>
        private string conn_str = @"Datasource=Data\small.db";

        public void Connect()
        {
            try
            {
                DbConnection conn = new SQLiteConnection(conn_str);
                conn.Open();
                Console.WriteLine("connection ok");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Insert()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            using (var conn = new SQLiteConnection(conn_str))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into cats (id,name,age) values(@id,@name,@age)";
                Console.WriteLine("插入中，请稍等");
                for (int i = 0; i < 1000; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SQLiteParameter("@id", Guid.NewGuid()));
                    cmd.Parameters.Add(new SQLiteParameter("@name", "cat " + i));
                    cmd.Parameters.Add(new SQLiteParameter("@age", i + 20));
                    cmd.ExecuteNonQuery();
                    //Console.WriteLine($"插入第{i}个");
                }
                conn.Close();
            }
            sw.Stop();
            Console.WriteLine($"共消耗{sw.ElapsedMilliseconds}ms");
        }


        public void DeleteAll()
        {
            using (var conn = new SQLiteConnection(conn_str))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "delete from cats";

                cmd.ExecuteNonQuery();
                Console.WriteLine($"全部删除");

                conn.Close();
            }
        }


    }
}
