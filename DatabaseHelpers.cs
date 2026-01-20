using MySql.Data.MySqlClient;

namespace DatabaseConnection
{
    public static class DatabaseHelpers
    {
        private static readonly string ServerConnectionString = "server=localhost;user=root;password=;port=3306;";
        private static readonly string DatabaseConnectionString = "server=localhost;user=root;password=;database=school;port=3306;";

        public static MySqlConnection GetServerConnection() => new MySqlConnection(ServerConnectionString);
        public static MySqlConnection GetDatabaseConnection() => new MySqlConnection(DatabaseConnectionString);

        public static void ExecuteNonQuery(MySqlConnection connection, string query, Action<MySqlCommand>? parameters = null)
        {
            using var cmd = new MySqlCommand(query, connection);
            parameters?.Invoke(cmd);
            cmd.ExecuteNonQuery();
        }
    }
}
