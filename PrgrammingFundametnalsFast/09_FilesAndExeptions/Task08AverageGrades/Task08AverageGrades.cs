using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04AverageGrades
{

    class Student
    {

        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double Average { get { return Grades.Average(); } }

        public Student(string name, List<double> grades)
        {
            this.Name = name;

            this.Grades = grades;
        }
    }
    class Task04AverageGrades
    {
        static void Main(string[] args)
        {

            var lines = File.ReadAllLines("input.txt");

            File.Delete("output.txt");

            int howMnayTimes = int.Parse(lines[0]);

            List<Student> students = new List<Student>();

            for (int i = 1; i < lines.Length; i++)
            {
                var input = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var name = input[0];

                var grades = input.Skip(1).Select(double.Parse).ToList();

                var currentStudent = new Student(name, grades);

                students.Add(currentStudent);
            }

            foreach (var student in students.Where(n => n.Average >= 5).OrderBy(n => n.Name).ThenByDescending(n => n.Average))
            {
                File.AppendAllText("output.txt",$"{student.Name} -> {student.Average:f2}\r\n");
            }
        }
    }
}