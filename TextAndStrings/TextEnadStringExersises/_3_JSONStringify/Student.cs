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

