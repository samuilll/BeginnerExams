using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


    class _3_BigFactorial
    {
        static void Main(string[] args)
        {
        var N = int.Parse(Console.ReadLine());

        BigInteger result = 1;

        for (int i = 2; i <= N; i++)
        {
            result = result*i;
        }

        Console.WriteLine(result);
        }
    }

