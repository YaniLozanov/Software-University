using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        // Problem:
        // Define a class Student, which holds the following information about students: name, list of grades and average grade (calculated property, read-only).
        // A single grade will be in range [2…6], e.g. 3.25 or 5.50.
        // Read a list of students and print the students that have average grade ≥ 5.00 ordered by name(ascending), then by average grade(descending).
        // Print the student name and the calculated average grade.


        static void Main(string[] args)
        {

            int studentsCount = int.Parse(Console.ReadLine());
            Student[] students = new Student[studentsCount];
            for (int i = 0; i < studentsCount; i++)
            {
                students[i] = ReadStudent(Console.ReadLine());
            }

            foreach (Student student in students.Where(x => x.AverageGrade >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine("{0} -> {1:F2}", student.Name, student.AverageGrade);
            }
        }

        static Student ReadStudent(string input)
        {
            string[] tokens = input.Split(' ');
            List<double> grades = new List<double>();
            foreach (string token in tokens.Skip(1))
            {
                grades.Add(double.Parse(token));
            }

            return new Student { Name = tokens[0], Grades = grades };
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get { return Grades.Sum() / Grades.Count; } }
    }
}