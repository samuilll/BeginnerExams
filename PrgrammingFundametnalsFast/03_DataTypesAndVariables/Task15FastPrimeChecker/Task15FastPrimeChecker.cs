using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task15FastPrimeChecker
    {
        static void Main(string[] args)
        {

        int firstNumber = 2;
        int secondNumber = int.Parse(Console.ReadLine());
        for (int currentNumber = firstNumber; currentNumber <= secondNumber; currentNumber++)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(currentNumber); i++)
            {
                if (currentNumber % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine($"{currentNumber} -> {isPrime}");
        }
    }
    }

