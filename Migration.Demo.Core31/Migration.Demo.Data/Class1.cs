using System;
using System.Data.SqlClient;

namespace Migration.Demo.Data
{
    public static class SqlHelper
    {
        public static string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=MigrationDemo;Integrated Security=true;";

        public static int GetValueFromDatabase()
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT TOP 1 [Value] FROM [dbo].[Demo]";
                    var value = int.Parse(cmd.ExecuteScalar().ToString());

                    return value;
                }
            }

            return -1;
        }
    }
}
