using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Extension.Functions
{
    [SQLiteFunction(Arguments = 1, FuncType = FunctionType.Scalar, Name = FunctionList.SQUARE)]
    internal class SquareFunction : BaseSQLiteFunction
    { 
        public override object Invoke(object[] args)
        {
            var d = Convert.ToDouble(args[0]);

            return Math.Pow(d, 2);
        }
         
    }
}
