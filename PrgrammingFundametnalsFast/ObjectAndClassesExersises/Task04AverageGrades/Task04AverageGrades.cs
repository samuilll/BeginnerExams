using System;
using System.Collections.Generic;
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
            int howMnayTimes = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < howMnayTimes; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var name = input[0];

                var grades = input.Skip(1).Select(double.Parse).ToList();
                
                var currentStudent = new Student(name, grades);

                students.Add(currentStudent);
            }

            foreach (var student in students.Where(n=>n.Average>=5).OrderBy(n=>n.Name).ThenByDescending(n=>n.Average))
            {
                Console.WriteLine($"{student.Name} -> {student.Average:f2}");
            }
        }
    }
}
