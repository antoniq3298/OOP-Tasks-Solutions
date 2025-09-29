using System;
using System.Collections.Generic;
using System.Linq;

abstract class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public abstract string GetInfo();
}

class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public override string GetInfo()
    {
        return $"{Name} is a Developer, skilled in {ProgrammingLanguage}, Salary: {Salary}";
    }
}

class Manager : Employee
{
    public int TeamSize { get; set; }

    public override string GetInfo()
    {
        return $"{Name} is a Manager of {TeamSize} people, Salary: {Salary}";
    }
}

class Program
{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new Developer { Name = "Alice", Salary = 3000, ProgrammingLanguage = "C#" },
            new Developer { Name = "Bob", Salary = 3500, ProgrammingLanguage = "Java" },
            new Manager { Name = "Charlie", Salary = 5000, TeamSize = 10 }
        };

        employees.ForEach(e => Console.WriteLine(e.GetInfo()));

        Console.WriteLine("\nDevelopers only:");
        var devs = employees.OfType<Developer>().ToList();
        devs.ForEach(d => Console.WriteLine(d.GetInfo()));
    }
}
