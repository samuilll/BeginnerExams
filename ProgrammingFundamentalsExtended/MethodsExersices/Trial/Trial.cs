using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncryption08
{
    class StringEncryption08
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            number = MakeTheNumberPositive(number);

            var digitsCount = GetTheNumberOfDigits(number);

            Console.WriteLine(digitsCount);

            var oddSum = GetTheSumOfTheOddDigits(number);

            var evenSum = GetTheSumOfTheEvenDigits(number);

            Console.WriteLine(oddSum * evenSum);
        }

        private static  int GetTheSumOfTheOddDigits(int number)
        {
            var count = GetTheNumberOfDigits(number);
            var oddSum = 0;
            var currentDigit = 0;
            for (int i = 0; i < count; i++)
            {
                currentDigit= number % 10;
                number /= 10;
                if (currentDigit%2!=0)
                {
                    oddSum += currentDigit;
                }
                          
            }
            return oddSum;
        }

        private static int GetTheSumOfTheEvenDigits(int number)
        {
            var count = GetTheNumberOfDigits(number);
            var evenSum = 0;
            var currentDigit = 0;
            for (int i = 0; i < count; i++)
            {
                currentDigit = number % 10;
                number /= 10;
                if (currentDigit % 2 == 0)
                {
                    evenSum += currentDigit;
                }

            }
            return evenSum;
        }

        private static int GetTheNumberOfDigits(int number)
        {
            var count = 0;
            while (number != 0)
            {
                number /= 10;
                count++;
            }

            return count;
        }

        private static int MakeTheNumberPositive(int number)
        {
           
            number = Math.Abs(number);
            
            return number;
        }
    }
}
