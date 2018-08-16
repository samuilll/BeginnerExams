using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


    class Task14FactorielTrailingZeroes
    {
        static void Main(string[] args)
        {
        {

            int n = int.Parse(Console.ReadLine());

            BigInteger factoriel = new BigInteger(1);

            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }

            var count = 0;

            while (factoriel%10==0)
            {
                count++;

                factoriel /= 10;
            }

            Console.WriteLine(count);
        }
    }
    }

