using System;
using DatabaseConnection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting database project...");

        // Step 1: Create database & table
        ConnectDatabaseInTable.CreateDatabaseAndTable();

        // Step 2: Ask user for student data
        Console.Write("Enter student ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter student DOB (yyyy-mm-dd): ");
        DateTime dob = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter student class: ");
        string className = Console.ReadLine();

        // Step 3: Insert user input into database
        InsertDataInTable.InsertStudent(id, name, dob, className);

        // Step 4: Confirm program finished
        Console.WriteLine("Program finished successfully.");
    }
}
