using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Extension.Functions
{
    [SQLiteFunction(Arguments = 1, FuncType = FunctionType.Scalar, Name = FunctionList.REPLACE)]
    internal class ReplaceFunction : BaseSQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            String s = Convert.ToString(args[0]),
                s1 = Convert.ToString(args[1]),
                s2 = Convert.ToString(args[2]);

            return s.Replace(s1, s2);
        }

    }
}
