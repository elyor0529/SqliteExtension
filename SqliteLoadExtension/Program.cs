using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.SQLite.Extension;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SqliteLoadExtension
{
    class Program
    {

        static Program()
        {
            SQLiteHelper.LoadExtensions();
        }

        static void Main(string[] args)
        {
            using (var connection = new SQLiteConnection("Data source=:memory:;Version=3;New=True;"))
            {
                connection.Open();
                using (var comm = connection.CreateCommand())
                {
                    comm.CommandText = @"select sqrt(23)";

                    var result = comm.ExecuteScalar();
                }
            }
        }
    }
}
