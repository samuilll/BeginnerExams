using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task09IndexOfLetters
    {
        static void Main(string[] args)
        {

        string alphabet = "abcdefghihklmnopqrstuvwxyz";

        string word = Console.ReadLine();

        foreach (var letter in word)
        {
            Console.WriteLine($"{letter} -> {alphabet.IndexOf(letter)}");
        }
        }
    }

