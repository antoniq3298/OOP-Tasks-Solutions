using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradesManager.Models
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; }

        public Student(string name)
        {
            Name = name;
            Grades = new List<int>();
        }

        public double GetAverage()
        {
            if (Grades.Count == 0) return 0;
            return Grades.Average();
        }

        public override string ToString()
        {
            return $"{Name} -> Average: {GetAverage():F2}";
        }
    }
}
