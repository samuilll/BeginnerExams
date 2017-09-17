using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BasycSyntax
    {
        static void Main(string[] args)
        {
        //    //exersise 1

        //    var grades = new Dictionary<string, List<int>>();

        //    grades["Pesho"] = new List<int>();

        //    grades["Pesho"].Add(3);
        //    grades["Pesho"].Add(4);
        //    grades["Pesho"].Add(5);

        //    grades["Kiro"] = new List<int>() { 5, 6, 5, 6 };

        //    AddGrade(grades, "Pesho", 2);
        //    AddGrade(grades, "Kiro", 2);


        //    Console.WriteLine("Pesho's grades: {0}", string.Join(" ", grades["Pesho"]));
        //    Console.WriteLine("Kiro's grades: {0}", string.Join(" ", grades["Kiro"]));

        //    Console.WriteLine();

        //    // Another way of printing

        //    Print(grades);

        //    // One More Way Of Printing

        //    AnotherPrintingWay(grades);
        //}

        //private static void AnotherPrintingWay(Dictionary<string, List<int>> grades)
        //{
        //    foreach (var nameAndGrades in grades)
        //    {
        //        Console.WriteLine($"{nameAndGrades.Key} -> {string.Join(" ",nameAndGrades.Value)}");                
        //    }
        //}

        //private static void Print(Dictionary<string, List<int>> grades)
        //{
        //    foreach (var name in grades.Keys)
        //    {
        //        Console.WriteLine($"Grades of {name} are:");

        //        foreach (var grade in grades[name])
        //        {
        //            Console.WriteLine($"- {grade}");
        //        }
        //    }
        //}

        //public static void AddGrade(Dictionary<string, List<int>> grades,string name, int grade)
        //    {
        //    if (!grades.ContainsKey(name))
        //    {
        //        grades[name] = new List<int>();
        //    }

        //    grades[name].Add(grade);
        //    }

        //end of exersise one

        //nested dictionaries

        //        var countriesTownsCitizens = new Dictionary<string, Dictionary<string, int>>();

        //        countriesTownsCitizens["Bulgaria"] = new Dictionary<string, int>();
        //        countriesTownsCitizens["Romania"] = new Dictionary<string, int>();
        //        countriesTownsCitizens["Denmark"] = new Dictionary<string, int>();
        //        countriesTownsCitizens["Germany"] = new Dictionary<string, int>();


        //        countriesTownsCitizens["Bulgaria"]["Dobrich"] = 80000;
        //        countriesTownsCitizens["Romania"]["Budapeshta"] = 2500000;
        //        countriesTownsCitizens["Bulgaria"]["Silistra"] = 40000;
        //        AddPopulation(countriesTownsCitizens, "Romania", "Konstanca", 20000);
        //        AddPopulation(countriesTownsCitizens, "Denmark", "Kopenhagen", 300000);
        //        AddPopulation(countriesTownsCitizens, "Bulgaria", "Sofia", 2000000);
        //        AddPopulation(countriesTownsCitizens,"Germany","Drezden",1000000);


        //        AddPopulation(countriesTownsCitizens, "USA", "New York", 11000000);

        //        AddPopulation(countriesTownsCitizens, "USA", "New York", 15000000);

        //        countriesTownsCitizens["Bulgaria"].Remove("Sofia");


        //        PrintTheNestedDictionary(countriesTownsCitizens);


        //    }

        //    private static void AddPopulation(Dictionary<string, Dictionary<string, int>> countriesTownsCitizens
        //        , string country, string town, int population)
        //    {
        //        if (!countriesTownsCitizens.ContainsKey(country))
        //        {
        //            countriesTownsCitizens[country] = new Dictionary<string, int>();
        //        }
        //        countriesTownsCitizens[country][town] = population;

        //    }

        //    private static void PrintTheNestedDictionary(Dictionary<string, Dictionary<string, int>> countriesTownsCitizens)
        //    {
        //        foreach (var country in countriesTownsCitizens.Keys)
        //        {
        //            Console.WriteLine($"{country}:");

        //            foreach (var town in countriesTownsCitizens[country].Keys)
        //            {
        //                Console.WriteLine($"Town '{town}' -> {countriesTownsCitizens[country][town]} citizens");
        //            }
        //            Console.WriteLine();
        //        }
        //    }

        // HashSets

        var List = new List<string>();

        var set = new HashSet<string>();

        List.Add("Plovdiv");
        List.Add("Sofia");
        List.Add("Dobrich");
        List.Add("Plovdiv");

          Console.WriteLine(string.Join(" ",List));

        set.Add("Dobrich");
        set.Add("Plovdiv");
        set.Add("Sofia");
        set.Add("Plovdiv");
        set.Add("Razgrad");


        Console.WriteLine(string.Join(" ", set));


        //  Console.WriteLine(string.Join(" ",List.Select(a => string.Format("{0}\n",a))));



    }
}
