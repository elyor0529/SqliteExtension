using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Extension.Functions
{
    [SQLiteFunction(Arguments = 1, FuncType = FunctionType.Scalar, Name = FunctionList.TRIM)]
    internal class TrimFunction : BaseSQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            String s = Convert.ToString(args[0]);

            return s.Trim();
        }

    }
}
