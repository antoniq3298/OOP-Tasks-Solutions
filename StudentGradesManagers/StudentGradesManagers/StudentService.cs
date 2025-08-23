using System;
using System.Collections.Generic;
using StudentGradesManager.Models;

namespace StudentGradesManager.Services
{
    public class StudentService
    {
        private List<Student> students;

        public StudentService()
        {
            students = new List<Student>();
        }

        public void AddStudent()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Student student = new Student(name);

            Console.Write("Enter grades (separated by space): ");
            string[] gradeInputs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var g in gradeInputs)
            {
                if (int.TryParse(g, out int grade))
                {
                    student.Grades.Add(grade);
                }
            }

            students.Add(student);
            Console.WriteLine($"Student {name} added successfully.");
        }

        public void PrintStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students yet.");
                return;
            }

            Console.WriteLine("\nStudents:");
            foreach (var s in students)
            {
                Console.WriteLine(s);
            }
        }
    }
}
