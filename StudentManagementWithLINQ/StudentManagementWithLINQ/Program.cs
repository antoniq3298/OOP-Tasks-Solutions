using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public double Grade { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Anna", Grade = 5.8 },
            new Student { Name = "Peter", Grade = 4.5 },
            new Student { Name = "Maria", Grade = 6.0 },
            new Student { Name = "John", Grade = 5.2 }
        };

        var topStudents = students
            .Where(s => s.Grade >= 5.0)
            .OrderByDescending(s => s.Grade);

        Console.WriteLine("Top students:");
        foreach (var student in topStudents)
        {
            Console.WriteLine($"{student.Name} - {student.Grade}");
        }
    }
}
