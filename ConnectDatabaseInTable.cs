using System;
using MySql.Data.MySqlClient;

namespace DatabaseConnection
{
    public class ConnectDatabaseInTable
    {
        public static void CreateDatabaseAndTable()
        {
            string databaseName = "school";

            using var connection = DatabaseHelpers.GetServerConnection();
            try
            {
                connection.Open();

                // Create database if not exists
                DatabaseHelpers.ExecuteNonQuery(connection, $"CREATE DATABASE IF NOT EXISTS {databaseName};");

                // Switch to database
                connection.ChangeDatabase(databaseName);

                // Create table if not exists
                string createTable = @"
                    CREATE TABLE IF NOT EXISTS student (
                        id INT AUTO_INCREMENT PRIMARY KEY,
                        name VARCHAR(50),
                        dob DATE,
                        class VARCHAR(20)
                    );";
                DatabaseHelpers.ExecuteNonQuery(connection, createTable);

                Console.WriteLine("Database and table 'student' are ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
