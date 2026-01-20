using System;
using MySql.Data.MySqlClient;

namespace DatabaseConnection
{
    public class InsertDataInTable
    {
        public static void InsertStudent(int id, string name, DateTime dob, string className)
        {
            using var connection = DatabaseHelpers.GetDatabaseConnection();
            try
            {
                connection.Open();

                string insertQuery = @"INSERT INTO student (id, name, dob, class) 
                                       VALUES (@id, @name, @dob, @class);";

                DatabaseHelpers.ExecuteNonQuery(connection, insertQuery, cmd =>
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@class", className);
                });

                Console.WriteLine("Student record inserted successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting student: " + ex.Message);
            }
        }
    }
}
