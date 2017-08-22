using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class _2_RandomizeWors
    {
        static void Main(string[] args)
        {
        var words = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        var randomiser = new Random();

        for (int i = 0; i < words.Length; i++)
        {
            var randomNumber = randomiser.Next(0, words.Length);
            var currentWord = words[i];

            var temporaryWord = words[randomNumber];
            words[randomNumber] = currentWord;
            words[i] = temporaryWord;
        }

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
    }

