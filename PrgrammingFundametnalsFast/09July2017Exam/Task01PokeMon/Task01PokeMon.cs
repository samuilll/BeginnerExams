using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task01PokeMon
    {
        static void Main(string[] args)
        {

        var N = long.Parse(Console.ReadLine());
        var M = long.Parse(Console.ReadLine());
        var Y = long.Parse(Console.ReadLine());
        var counter = 0;
        var originalN = N;

        while (N>=M)
        {
            N -= M;
            counter++;
            if (N*2==originalN && Y!=0)
            {
                if (N/Y>0)
                {
                    N = N / Y;
                }
            }
        }

        Console.WriteLine(N);
        Console.WriteLine(counter);


    }
}

