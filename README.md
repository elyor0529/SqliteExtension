SqliteLoadExtension
===================

Sqlite Load Extension

Functions:


        //math
        square
        sqrt
        floor
        ceil
        power

        //aggr
        median

        //string
        trim
        replace

Demostrations:


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
