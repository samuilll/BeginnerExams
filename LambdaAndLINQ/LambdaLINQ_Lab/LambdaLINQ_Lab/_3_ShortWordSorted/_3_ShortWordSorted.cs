using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ShortWordSorted
{
    class _3_ShortWordSorted
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var searched = text.Where(word => word.Length < 5)
                .Select(word =>word.ToLower())
                .OrderBy(word => word)
                .Distinct()
            .ToArray();

            Console.WriteLine(string.Join(", ",searched));
        }
    }
    }
