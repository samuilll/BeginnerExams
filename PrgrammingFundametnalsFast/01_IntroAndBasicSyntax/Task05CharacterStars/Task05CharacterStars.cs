using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 //dsaldslfkjdskflksajdkjsd
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            var H1 = int.Parse(Console.ReadLine());
            var H2 = int.Parse(Console.ReadLine());

            var E1 = int.Parse(Console.ReadLine());
            var E2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |{0}{1}|", new string('|', H1), new string('.', H2 - H1));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', E1), new string('.', E2 - E1));
        }
    }
}