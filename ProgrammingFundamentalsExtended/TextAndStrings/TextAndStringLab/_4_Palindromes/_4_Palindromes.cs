using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class _4_Palindromes
    {
        static void Main(string[] args)
        {
        var text = Console.ReadLine()
           .Split(new char[] {' ','.',',','?','!'}, StringSplitOptions.RemoveEmptyEntries)
           .ToArray();

        var result = new HashSet<string>();

        foreach (var word in text)
        {
            var comparison = string.Join("",word.ToCharArray().Reverse());

        
            if (word == comparison)
            {
                result.Add(word);
            }
        }

     Console.WriteLine(string.Join(", ", result.OrderBy(n=>n)));
    }
    }

