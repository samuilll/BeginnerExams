using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


    class Program
    {
        static void Main(string[] args)
        {

        int N = int.Parse(Console.ReadLine());

        decimal total = 0;

        for (int i = 0; i < N; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy",CultureInfo.InvariantCulture);

            long daysInMonth = DateTime.DaysInMonth(date.Year,date.Month);

            long capsulesCount = int.Parse(Console.ReadLine());

            decimal currentSum = (daysInMonth * capsulesCount) * pricePerCapsule;

            Console.WriteLine($"The price for the coffee is: ${currentSum:f2}");

            total += currentSum;
        }

        Console.WriteLine($"Total: ${total:f2}");

        }
    }

