using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    class _3_WordCount
    {
        static void Main(string[] args)
        {
        var firstFileWords = File
            .ReadAllText("words.txt")
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(word=>word.ToLower())
            .ToArray();

        var secondFileWords = File
            .ReadAllText("text.txt")
            .Split(new char[] { ' ','\n','\r','.',',','-' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(word => word.ToLower())
            .ToArray();

        var sort = new Dictionary<string, int>();

        for (int i = 0; i < secondFileWords.Length; i++)
        {
            if (firstFileWords.Contains(secondFileWords[i]))
            {
                if (!sort.ContainsKey(secondFileWords[i]))
                {
                    sort[secondFileWords[i]] = 0;
                }
                sort[secondFileWords[i]] += 1;
            }
        }

        sort = sort
             .OrderByDescending(n => n.Value)
             .ToDictionary(n=>n.Key,n=>n.Value);

        foreach (var pair in sort)
        {
            File.AppendAllText("output.txt",pair.Key  + " - " + pair.Value + Environment.NewLine);
        }

        foreach (var line in File.ReadAllLines("output.txt"))
        {
            Console.WriteLine(line);
        }
   
    }
    }

