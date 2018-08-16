using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08LettersChangeNumbers
{
    class Task08LettersChangeNumbers
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' ,'\t'}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            decimal sum = 0;

            string lowerAlphabet = "abcdefghijklmnopqrstuvwxyz";

            foreach (var text in input)
            {
                sum += ImplementTheOperations(text,lowerAlphabet);
            }

            Console.WriteLine($"{sum:f2}");
        }

        private static decimal ImplementTheOperations(string text,string alhabet)
        {
            char firstLetter = text[0];

            char secondLetter = text[text.Length - 1];

            decimal number = decimal.Parse(text.Substring(1,text.Length-2));

            if (char.IsUpper(firstLetter))
            {
                number = number / (alhabet.IndexOf(char.ToLower(firstLetter))+1);
            }
            else
            {
                number = number * (alhabet.IndexOf(char.ToLower(firstLetter))+1);
            }
            if (char.IsUpper(secondLetter))
            {
                number = number - (alhabet.IndexOf(char.ToLower(secondLetter))+1);
            }
            else
            {
                number = number + (alhabet.IndexOf(char.ToLower(secondLetter))+1);
            }


            return number;
        }
    }
}
