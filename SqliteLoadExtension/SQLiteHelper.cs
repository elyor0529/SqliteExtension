using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SqliteLoadExtension.Functions;

namespace SqliteLoadExtension
{
    public static class SQLiteHelper
    { 
        public static void LoadExtensions()
        {
            SQLiteFunction.RegisterFunction(typeof(SqrtFunction)); 
        }

    }
}
