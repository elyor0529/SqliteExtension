using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Extension.Functions
{
    [SQLiteFunction(Arguments = 2, FuncType = FunctionType.Scalar, Name = FunctionList.POWER)]
    internal class PowerFunction : BaseSQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            double d1 = Convert.ToDouble(args[0]),
                d2 = Convert.ToDouble(args[1]);

            return Math.Pow(d1, d2);
        }

    }
}
