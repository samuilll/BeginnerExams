using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camel_sBack03
{
    class Program
    {
        static void Main(string[] args)
        {
            var buildings = Console.ReadLine()
             .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse).
             ToList();

            var camelsBack = int.Parse(Console.ReadLine());

            var side = (buildings.Count - camelsBack) / 2;

            var rounds = 0;

            var check = false;

            for (int i = 0; i < side;i++)
            {
                buildings.RemoveAt(0);

                buildings.RemoveAt(buildings.Count-1);

                rounds++;

                check = true;

            }

            if (check)
            {
                Console.WriteLine($"{rounds} rounds");

                Console.WriteLine($"remaining: {string.Join(" ",buildings)}");
            }

            else
            {
                Console.WriteLine($"already stable: {string.Join(" ", buildings)}");
            }
        }
    }
}
