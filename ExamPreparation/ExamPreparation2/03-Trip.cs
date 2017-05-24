using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Trip03
{
    static void Main(string[] args)
    {
        var budget = decimal.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        if (budget <= 100)
        {
            if (season == "summer")
                Console.WriteLine("Somewhere in Bulgaria\n{0} - {1:f2}", "Camp", 30 * budget / 100);
            else
                Console.WriteLine("Somewhere in Bulgaria\n{0} - {1:f2}", "Hotel", 70 * budget / 100);
        }
        else if (budget <= 1000)
        {
            if (season == "summer")
                Console.WriteLine("Somewhere in Balkans\n{0} - {1:f2}", "Camp",40 * budget / 100);
            else
                Console.WriteLine("Somewhere in Balkans\n{0} - {1:f2}", "Hotel", 80 * budget / 100);
        }
        else


            Console.WriteLine("Somewhere in Europe\n{0} - {1:f2}", "Hotel",90 * budget / 100);
           
        
    }
}

