using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeRadioFrequencies05
{
    class DecodeRadioFrequencies05
    {
        static void Main(string[] args)
        {
            List<string> frequencies = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .ToList();

            var foundedText = new List<char>();

            for (int i = 0; i < frequencies.Count; i++)
            {
                var firstLetter = FoundTheFirstLetter(frequencies[i]);

                var secondLetter = FoundTheSecondLetter(frequencies[i]);

                FullTheList(foundedText, firstLetter, secondLetter, i);
            }

            Console.WriteLine(string.Join("",foundedText));
        }

        private static void FullTheList(List<char> foundedText, char firstLetter, char secondLetter, int i)
        {
            if(Convert.ToInt32(firstLetter) != 0)

            foundedText.Insert(i, firstLetter);

            if (Convert.ToInt32(secondLetter)!=0)

                foundedText.Insert(foundedText.Count-i, secondLetter);

        }

        private static char FoundTheFirstLetter(string frequence)
        {
            string[] numbers = frequence.Split('.');

            var firstNumber = int.Parse(numbers[0]);

            return Convert.ToChar(firstNumber);
        }

        private static char FoundTheSecondLetter(string frequence)
        {
            string[] numbers = frequence.Split('.');

            var secondNumber = int.Parse(numbers[1]);

            return Convert.ToChar(secondNumber);
        }
    }
}
