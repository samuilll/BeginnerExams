using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class _1_ArrayData
    {
        static void Main(string[] args)
        {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        numbers = numbers
             .Where(n => n >= numbers.Average())
             .ToList();

        var criterion = Console.ReadLine();

        if (criterion=="Min")
        {
            Console.WriteLine(numbers.Min());
        }
        else if (criterion == "Max")
        {
            Console.WriteLine(numbers.Max());

        }
        else if (criterion == "All")
        {
            Console.WriteLine(string.Join(" ",numbers.OrderBy(n=>n)));
        }
    }
    }

