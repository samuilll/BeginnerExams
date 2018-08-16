using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var profession = Console.ReadLine();

        if (profession == "Athlete")
            Console.WriteLine("Water");
        else if (profession == "Businessman" || profession == "Businesswoman")
            Console.WriteLine("Coffee");
        else if (profession == "SoftUni Student")
            Console.WriteLine("Beer");
        else
            Console.WriteLine("Tea");
    }
}

//“Water” – for “Athlete”
//“Coffee” – for “Businessman” or “Businesswoman”
//“Beer” – for “SoftUni Student”
//“Tea” – for all other professions.