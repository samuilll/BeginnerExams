using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task06IntervalOfNumbers
    {
        static void Main(string[] args)
        {
        int firstNumber = int.Parse(Console.ReadLine());

        int secondNumber = int.Parse(Console.ReadLine());

        if (secondNumber>firstNumber)
        {
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            for (int i = secondNumber; i <= firstNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
     

    }
}

