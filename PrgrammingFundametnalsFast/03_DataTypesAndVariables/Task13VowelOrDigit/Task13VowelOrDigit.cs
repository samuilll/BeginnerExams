using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task13VowelOrDigit
    {
        static void Main(string[] args)
        {
        string letter = Console.ReadLine();

        string vowels = "aeiouAEIOU";

        if (int.TryParse(letter,out int number))
        {
            Console.WriteLine("digit");
        }
        else if (vowels.IndexOf(letter)>=0)
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }
        }
    }

