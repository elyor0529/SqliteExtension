using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Extension.Functions
{

    [SQLiteFunction(Arguments = -1, FuncType = FunctionType.Aggregate, Name = FunctionList.MEDIAN)]
    internal class MedianFunction : BaseSQLiteFunction
    {
        public override object Invoke(object[] args)
        {

            double[] array = args.Select(s => Convert.ToDouble(s)).ToArray();

            Array.Sort(array);

            int size = array.Length;
            double result;

            // even
            if (size % 2 == 0)
            {
                int midIndex = size / 2;

                result = ((array[(midIndex - 1)] + array[midIndex]) / 2);
            }
            else // odd
            {
                double element = Math.Round((double)size / 2, MidpointRounding.AwayFromZero);

                result = array[(int)(element - 1)];
            }

            return result;
        }

    }
}
