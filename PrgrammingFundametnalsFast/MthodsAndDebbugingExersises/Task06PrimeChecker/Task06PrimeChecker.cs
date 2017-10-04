using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task06PrimeChecker
    {
        static void Main(string[] args)
        {

        long number = long.Parse(Console.ReadLine());

        bool isPrime = CheckIfTheNumberIsPrime(number);

        Console.WriteLine(isPrime);
        }

    private static bool CheckIfTheNumberIsPrime(long number)
    {
        if (number==2)
        {
            return true;
        }
        if (number==0||number==1||number%2==0)
        {
            return false;
        }

        int boundary = (int)Math.Floor(Math.Sqrt(number));

        for (long i = 3; i <=boundary; i+=2)
        {
            if (number%i==0)
            {
                return false;
            }
        }

        return true;
    }
}

