using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task04SieveOfEratosthenes
    {
        static void Main(string[] args)
    {

        int number = int.Parse(Console.ReadLine());

        bool[] primes = new bool[number+1];

        primes[0] = primes[1] = false;

        for (int i = 2; i < primes.Length; i++)
        {
            primes[i] = true;
        }

        int firstNumber = 2;

        while (firstNumber!=0)
        {
            firstNumber = FindThePrimesNumbers(primes, firstNumber);
        }

        for (int i = 0; i < primes.Length; i++)
        {
            if (primes[i]==true)
            {
                Console.Write($"{i} ");
            }
        }
        
    }

    private static int FindThePrimesNumbers(bool[] primes, int firstNumber)
    {
        bool thereIsMorePrimes = false;

        for (int i = 2 * firstNumber; i < primes.Length; i += firstNumber)
        {
            primes[i] = false;
        }
        for (int i = firstNumber + 1; i < primes.Length; i++)
        {
            if (primes[i] == true)
            {
                thereIsMorePrimes = true;
                firstNumber = i;
                break;
            }
        }

        if (thereIsMorePrimes)
        {
            return firstNumber;
        }
        else
        {
            return 0;
        }
    }
}

