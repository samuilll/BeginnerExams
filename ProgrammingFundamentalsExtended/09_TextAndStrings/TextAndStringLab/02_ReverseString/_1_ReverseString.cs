using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ReverseString
{
    class _1_ReverseString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var newstring = new StringBuilder();

            for (int i = input.Length-1; i >=0; i--)
            {
                newstring.Append(input[i]);
            }

            Console.WriteLine(string.Join("",newstring));
        }
    }
}
