using System;
using StudentGradesManager.Services;

namespace StudentGradesManager
{
    class Program
    {
        static void Main()
        {
            StudentService service = new StudentService();

            while (true)
            {
                Console.Write("\nCommand (add/list/exit): ");
                string input = Console.ReadLine();
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries); 
                if (parts.Length == 0) continue;
                string command = parts[0].ToLower();

                switch (command)
                {
                    case "add":
                        service.AddStudent();
                        break;
                    case "list":
                        service.PrintStudents();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            }
        }
    }
}