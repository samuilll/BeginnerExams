using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task09IndexOfLetters
{
    static void Main(string[] args)
    {
        string word = File.ReadAllText("input.txt");

        File.Delete("output.txt");

        string alphabet = "abcdefghihklmnopqrstuvwxyz";

        foreach (var letter in word)
        {
            File.AppendAllText("output.txt",$"{letter} -> {alphabet.IndexOf(letter)}\r\n");
        }
    }
}