using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buterrfly05
{
    class Buterrfly05
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
                else
                    Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
            }
            Console.WriteLine("{0}@{0}", new string(' ', n - 1));

            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
                else
                    Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
            }

        }
    }
}

//Да се напише програма, която прочита от конзолата цяло число n и чертае пеперуда с ширина 2 * n - 1 колони и височина 2 * (n - 2) + 1
//реда като в примерите по-долу.  Лявата и дясната ѝ част са широки 
//*****\ /***** 7
//-----\ /-----
//*****\ /*****
//-----\ /-----
//*****\ /*****
//      @
//*****/ \*****
//-----/ \-----
//*****/ \*****
//-----/ \-----
//*****/ \*****
