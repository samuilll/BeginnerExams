using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class _2_StringDecryption
    {
        static void Main(string[] args)
        {
        var twoNums = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray()
            .Where(n => (n >= 65 && n <= 90))
            .Skip(twoNums[0])
            .Take(twoNums[1])
            .Select(n => Convert.ToChar(n))
            .ToList();

        Console.WriteLine(string.Join("",numbers));
    }
    }

