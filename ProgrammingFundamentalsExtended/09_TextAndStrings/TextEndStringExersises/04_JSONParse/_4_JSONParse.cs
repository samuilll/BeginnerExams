using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string Name { get; set; }

    public int Age { get; set; }

    public List<int> Grades { get; set; }

    public Student(string name, int age, List<string> grades)
    {
        this.Name = name;
        this.Age = age;
        this.Grades = new List<int>();

        for (int i = 0; i < grades.Count; i++)
        {
            this.Grades.Add(int.Parse(grades[i]));
        }
    }
}
class _4_JSONParse
    {
        static void Main(string[] args)
        {
        var inputLine = Console.ReadLine()
           .Split(new string[] { "},{"}, StringSplitOptions.RemoveEmptyEntries)
           .ToArray();

        var studentList = new List<Student>(); 

        foreach (var line in inputLine)
        {
            var separateStdentParams = line.Split(new char[] {'{','}',',',' ',':','[',']','\"',},StringSplitOptions.RemoveEmptyEntries);

            var name = separateStdentParams[1];

            var age = int.Parse(separateStdentParams[3]);

            var grades = separateStdentParams.Skip(5).ToList();

            studentList.Add(new Student(name,age,grades));
        }
        foreach (var student in studentList)
        {
            if (student.Grades.Count!=0)
            {
                Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(", ", student.Grades)}");
            }
            else
            {
                Console.WriteLine($"{student.Name} : {student.Age} -> {"None"}");

            }
        }
    }
    }

