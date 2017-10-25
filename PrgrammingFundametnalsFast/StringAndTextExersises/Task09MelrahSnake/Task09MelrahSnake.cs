using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09MelrahSnake
{
    class Task09MelrahSnake
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            string pattern = Console.ReadLine();

            bool check = true;

            while (check)
            {
                var first = text.IndexOf(pattern);

                var second = text.LastIndexOf(pattern);

                if (first==second)
                {
                    break;
                }
                if (pattern.Length==0)
                {
                    break;
                }

                text = text.Remove(first,pattern.Length);

                second = text.LastIndexOf(pattern);

                text = text.Remove(second, pattern.Length);

                var f = pattern.Length / 2;

                pattern = pattern.Remove(pattern.Length/2,1);

                Console.WriteLine("Shaked it.");

            }

            Console.WriteLine("No shake.");

            Console.WriteLine(text);
            var a = text.IndexOf("abc");

            var b = text.LastIndexOf("abc");

            

            Console.WriteLine();

        }
    }
}
