using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Syntax
{
    static void Main(string[] args)
    {
        var trial = new List<int> { 1, 2, 3, 101, 5, 11, 7, 7, 19 };

        var firstThree = trial.Take(3);
        firstThree = trial.OrderBy(n => n).Skip(5).ToList();
        Console.WriteLine(string.Join(" ", firstThree));
        Console.WriteLine();

        //------------------------------------------------------------

        Console.WriteLine(trial.Count(n=>n>10));
        Console.WriteLine();

        //------------------------------------------------------------

        var sum = trial.Sum();
        var min = trial.Min();
        var average = trial.Average();
        var bigNums = trial.Where(a => a >= 5).ToList();
        Console.WriteLine("{0}\n{1}\n{2}\n{3}", sum, min, average, string.Join(" ", bigNums));
        Console.WriteLine();

        //------------------------------------------------------------


        trial.Reverse();
        Console.WriteLine(string.Join(" ", trial));
        Console.WriteLine();

        //------------------------------------------------------------


        var sorted = trial.OrderBy(n => n).ToList();
        Console.WriteLine(string.Join(" ", sorted));
        Console.WriteLine();

        //------------------------------------------------------------


        sorted = trial.OrderByDescending(n => n).ToList();
        Console.WriteLine(string.Join(" ", sorted));
        Console.WriteLine();

        //------------------------------------------------------------

        var students = new Dictionary<string, int>()
        {
            ["ivan"] = 6,
            ["pesho"] = 1,
            ["gosho"] = 2,
            ["ani"] = 2,
            ["hogo"] = 4,
        };

         var sortedstudents = students.OrderBy(n => n.Value)
            .ThenBy(n=>n.Key);


        foreach (var pair in sortedstudents)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }

        Console.WriteLine( );

        //------------------------------------------------------------


        sortedstudents = students.OrderBy(n => n.Value)
            .ThenByDescending(n => n.Key);

        foreach (var pair in sortedstudents)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }

        students = students.OrderBy(n => n.Value)
           .ThenBy(n => n.Key)
           .ToDictionary(n=>n.Key,n=>n.Value);
        Console.WriteLine();

        //------------------------------------------------------------

        var isThere = trial.Where(n => n > 1000)
            .Any();

        var isThereAgain = trial.Any(n => n > 100);
        var areAllNumbers = trial.All(n => n > -1);
        Console.WriteLine(isThere);
        Console.WriteLine(areAllNumbers);
        Console.WriteLine();

        //------------------------------------------------------------

        var unique = trial.Distinct().ToList();
        Console.WriteLine(string.Join(" ",trial));

        //---------------------------------------

        var first = trial.Where(n => n > 5).First();

        var last = trial.Where(n => n > 5).Last();

        var single = trial.Where(n => n > 5).Single();

        var firstDef = trial.Where(n => n > 5).FirstOrDefault();

        //----------------------

        var nums = new int[] { 5,7,8,93214};

        var union = trial.Concat(nums);

        //------------------------




    }
}   

