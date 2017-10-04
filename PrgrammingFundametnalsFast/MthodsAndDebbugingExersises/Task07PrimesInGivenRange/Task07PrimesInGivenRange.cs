using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task07PrimesInGivenRange
    {
        static void Main(string[] args)
    {

        long firstLimitingNumber = long.Parse(Console.ReadLine());

        long secondLimitingNumber = long.Parse(Console.ReadLine());

        List<long> primeNumbersList = AddThePrimeNumbersInAList(firstLimitingNumber, secondLimitingNumber);

      //  Console.WriteLine(primeNumbersList.Count);

        Console.WriteLine(string.Join(", ",primeNumbersList));



    }

    private static List<long> AddThePrimeNumbersInAList(long firstLimitingNumber, long secondLimitingNumber)
    {

        List<long> primeNumbersList = new List<long>();

        for (long i = firstLimitingNumber; i <= secondLimitingNumber; i++)
        {
            if (CheckIfTheNumberIsPrime(i))
            {
                primeNumbersList.Add(i);
            }
        }

        return primeNumbersList;
    }

    private static bool CheckIfTheNumberIsPrime(long number)
    {
        if (number == 2)
        {
            return true;
        }
        if (number == 0 || number == 1 || number % 2 == 0)
        {
            return false;
        }

        int boundary = (int)Math.Floor(Math.Sqrt(number));

        for (long i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}

