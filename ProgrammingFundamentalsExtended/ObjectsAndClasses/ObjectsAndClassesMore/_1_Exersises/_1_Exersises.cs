using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _1_Exersises
{
    static void Main(string[] args)
    {

        var inputLine = Console.ReadLine();

        var ListOfExersises = new List<Exersise>();

        while (inputLine != "go go go")
        {
            var currentExersise = Exersise.Parse(inputLine);

            ListOfExersises.Add(currentExersise);

            inputLine = Console.ReadLine();
        }

        PrintTheResult(ListOfExersises);
    }

    private static void PrintTheResult(List<Exersise> listOfExersises)
    {
        foreach (var Exersise in listOfExersises)
        {
            Console.WriteLine($"Exercises: {Exersise.Topic}");
            Console.WriteLine($"Problems for exercises and homework for the \"{Exersise.CourseName}\" course @ SoftUni.");
            Console.WriteLine($"Check your solutions here: {Exersise.JudgeContestLink}");

            var i = 1;

            foreach (var problem in Exersise.Problems)
            {
                Console.WriteLine($"{i}. {problem}");
                i++;
            }
        }
    }
}

