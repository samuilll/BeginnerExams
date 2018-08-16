using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task03UnicodeCharacters
{
    class Task03UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var character in input)
            {
                Console.Write("\\u{0}",((int)character).ToString("x4"));
            }
        }
    }
}
