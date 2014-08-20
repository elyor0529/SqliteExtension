using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Extension.Functions
{
    public class BaseSQLiteFunction : SQLiteFunction
    {
        #region Overrides of SQLiteFunction

        /// <summary>
        /// Scalar functions override this method to do their magic.
        /// </summary>
        /// <remarks>
        /// Parameters passed to functions have only an affinity for a certain data type, there is no underlying schema available
        ///             to force them into a certain type.  Therefore the only types you will ever see as parameters are
        ///             DBNull.Value, Int64, Double, String or byte[] array.
        /// </remarks>
        /// <param name="args">The arguments for the command to process</param>
        /// <returns>
        /// You may return most simple types as a return value, null or DBNull.Value to return null, DateTime, or
        ///             you may return an Exception-derived class if you wish to return an error to SQLite.  Do not actually throw the error,
        ///             just return it!
        /// </returns>
        public override object Invoke(object[] args)
        {
            if (!args.Any())
                return null;

            return args.Contains(DBNull.Value)
                ? null
                : base.Invoke(args);
        }

        #endregion
    }
}
