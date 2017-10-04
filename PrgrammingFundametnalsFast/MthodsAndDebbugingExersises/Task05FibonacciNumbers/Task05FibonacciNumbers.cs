using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task05FibonacciNumbers
    {
        static void Main(string[] args)
        {

        long number = long.Parse(Console.ReadLine());

        long fibonacciInNumber = Fib(number);

        Console.WriteLine(fibonacciInNumber);
        }

    private static long Fib(long number)
    {
        if (number==0)
        {
            return 1;
        }
        if (number==1 || number==2)
        {
            return number;
        }

        long previousNumber = 1;

        long currentNumber = 2;

        long nextNumber = 0;

        for (long i = 2; i < number; i++)
        {
            nextNumber = previousNumber + currentNumber;

            previousNumber = currentNumber;

            currentNumber = nextNumber;
        }

        return currentNumber;
    }
}

