using System.Linq;

namespace System.Data.SQLite.Extension.Functions
{
    [SQLiteFunction(Arguments = 1, FuncType = FunctionType.Scalar, Name = FunctionList.SQRT)]
    internal class SqrtFunction : BaseSQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            var d = Convert.ToDouble(args[0]);
            return Math.Sqrt(d);
        }

    }
}
