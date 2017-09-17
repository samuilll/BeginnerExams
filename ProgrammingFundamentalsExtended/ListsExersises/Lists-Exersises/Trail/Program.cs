using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trail
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).
               ToList();

            RemoveDigits(firstLine);

            Console.WriteLine(string.Join(" ",firstLine));


        }

        private static void RemoveDigits(List<int> firstLine)
        {
            firstLine.RemoveAt(2);
        }
    }
}
