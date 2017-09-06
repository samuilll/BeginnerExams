using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class _3_JSONStringify
{
    static void Main(string[] args)
    {

        var inputLine = Console.ReadLine()
            .Split(new string[] { " : ", " ->" }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        var studentsStore = new Dictionary<string, Student>();

        while (inputLine[0] != "stringify")
        {
            var name = inputLine[0];

            var age = int.Parse(inputLine[1]);

            var grades = new List<string>();


            if (inputLine.Length == 3)
            {
                grades = inputLine[2].Trim().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }


            var currentStudent = new Student(name, age, grades);

            studentsStore[name] = currentStudent;

            inputLine = Console.ReadLine()
            .Split(new string[] { " : ", " ->" }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        }

        var result = new StringBuilder();

        result.Append("[");

        foreach (var student in studentsStore)
        {                        
                result.Append($"{{name:\"{student.Value.Name}\",age:{student.Value.Age},grades:[{string.Join(", ", student.Value.Grades)}]}},");
        }

        result.Remove(result.Length-1,1);

        result.Append("]");

        Console.WriteLine(result.ToString());
    }
}

