using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Division04
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var p1 = 0;
            var p2 = 0;
            var p3 = 0;
            for (int i = 1; i <= number; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num % 2 == 0) p1++;
                if (num % 3 == 0) p2++;
                if (num % 4 == 0) p3++;
            }
            Console.WriteLine("{0:f2}%",(double)p1*100/number);
            Console.WriteLine("{0:f2}%", (double)p2 * 100 / number);
            Console.WriteLine("{0:f2}%", (double)p3 * 100 / number);
        }
    }

