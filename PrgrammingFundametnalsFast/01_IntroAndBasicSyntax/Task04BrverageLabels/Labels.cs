using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 //alskdjlksajdlkjsad//dsaljldsjflkdf//lksa;dksa;lkdsad
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();

            var vol = double.Parse(Console.ReadLine());

            var energy = double.Parse(Console.ReadLine());

            var sugar = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}ml {1}:", vol, product);
            Console.WriteLine("{0}kcal, {1}g sugars", vol / 100 * energy, vol / 100 * sugar);
        }
    }
}