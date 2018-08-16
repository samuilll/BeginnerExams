using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _6_FilterBase
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split(new string[] { " ", "->" }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        var num = new int[3];

        var agesList = new Dictionary<string, int>();

        var salariesList = new Dictionary<string, double>();

        var positionsList = new Dictionary<string, string>();

        while (input[0] != "filter")
        {
            var name = input[0];

            var checkAge = int.TryParse(input[1], out int age);

            var checkSalary = double.TryParse(input[1], out double salary);

            if (checkAge)
            {
                FillTheAgeList(name, age, agesList);
            }
            else if (checkSalary)
            {
                FillTheSalaryList(name, salary, salariesList);
            }
            else
            {
                var position = input[1];

                FillThePositionsList(name, position, positionsList);
            }

            input = Console.ReadLine()
            .Split(new string[] { " ", "->" }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        }

        var whatKindOfInfo = Console.ReadLine();

        switch (whatKindOfInfo)
        {
            case "Position":
                {
                    foreach (var kvp in positionsList)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");

                        Console.WriteLine($"Position: {kvp.Value}");

                        Console.WriteLine("====================");
                    }
                    break;
                }
            case "Salary":
                {
                    foreach (var kvp in salariesList)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");

                        Console.WriteLine($"Salary: {kvp.Value:f2}");

                        Console.WriteLine("====================");

                    }
                    break;
                }
            case "Age":
                {
                    foreach (var kvp in agesList)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");

                        Console.WriteLine($"Age: {kvp.Value}");

                        Console.WriteLine("====================");

                    }
                    break;
                }
        }


    }

    private static void FillThePositionsList(string name, string position, Dictionary<string, string> positionsList)
    {
        positionsList[name] = position;
    }

    private static void FillTheSalaryList(string name, double salary, Dictionary<string, double> salariesList)
    {
        salariesList[name] = salary;
    }

    private static void FillTheAgeList(string name, int age, Dictionary<string, int> agesList)
    {
        agesList[name] = age;
    }
}

