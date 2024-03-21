using System;
using System.Data.SqlClient;

namespace DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var constr = GetconnectionString();
            using (SqlConnection connection = new SqlConnection(constr))
            {
                try
                {
                    connection.Open();
                    ExecuteCommand("select * from users", connection);
                    ExecuteCommand("select * from posts", connection);
                    ExecuteCommand("select * from comments", connection);
                }
                catch (Exception e)
                {

                }
            }
        }

        private static void ExecuteCommand(string commandStr, SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand(commandStr, connection))
            {
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var result = String.Empty;
                        for (int i = 0; i < reader.FieldCount - 1; i++)
                        {
                            result += $"{reader.GetValue(i).ToString()} ";
                        }
                        Console.WriteLine(result);

                    }
                }
            }
        }

        private static string GetconnectionString()
        {
            return $"server=localhost;database=Avito;MultipleActiveResultSets=True;TrustServerCertificate=True;Connect Timeout=30;Integrated Security=true;";
        }
    }
}
