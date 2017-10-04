using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task01HellooName
{
    static void Main(string[] args)
    {

        string name = Console.ReadLine();

        Greeting(name);
    }

    private static void Greeting(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

