using System.Data.SQLite.Extension.Functions;

namespace System.Data.SQLite.Extension
{
    public static class SQLiteHelper
    {
        public static void LoadExtensions()
        {
            //math
            SQLiteFunction.RegisterFunction(typeof(SqrtFunction));
            SQLiteFunction.RegisterFunction(typeof(SquareFunction));
            SQLiteFunction.RegisterFunction(typeof(CeilFunction));
            SQLiteFunction.RegisterFunction(typeof(FloorFunction));
            SQLiteFunction.RegisterFunction(typeof(PowerFunction));
            SQLiteFunction.RegisterFunction(typeof(PowerFunction));

            //string
            SQLiteFunction.RegisterFunction(typeof(ReplaceFunction));
            SQLiteFunction.RegisterFunction(typeof(TrimFunction));

            //aggr
            SQLiteFunction.RegisterFunction(typeof(MedianFunction));

        }

    }
}
