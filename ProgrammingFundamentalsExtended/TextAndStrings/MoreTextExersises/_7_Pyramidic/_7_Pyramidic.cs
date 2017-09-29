using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _7_Pyramidic
{
    static void Main(string[] args)
    {
        var repeats = int.Parse(Console.ReadLine());

        var PyramidList = new Dictionary<char, SortedSet <int>>();

        string[] words = new string[repeats];

        for (int i = 0; i < repeats; i++)
        {
            var word = Console.ReadLine();

            words[i] = word;
        }

        var count = 1;

        var check = false;

        var specialCount = 0;

        for (int i = 1; i < words.Length; i++)
        {
            var letters = new List<int>();

            var currentWord = words[i];

            var previousWord = words[i - 1];

            foreach (var letter in currentWord)
            {
                if (letters.Count(n=>n==letter)==1)
                {
                    specialCount = count;
              
                    count -=2;
                }

                if (ContainsMethod(letter,count,previousWord) && ContainsMethod(letter,count+2,currentWord) )
                {
                    if (!PyramidList.ContainsKey(letter))
                    {
                        PyramidList[letter] = new SortedSet<int>();
                    }
                    if (!letters.Contains(letter))
                    {
                        PyramidList[letter].Add(count + 2);

                        count += 2;

                        check = true;

                        letters.Add(letter);

                    }
                    else
                    {
                        letters.Add(letter);
                    }
                }
            }
            if (!check)
            {
                count = 1;
            }
            else
            {
                count = specialCount;
            }

            check = false;
        }

        if (PyramidList.Keys.Count!=0)
        {
            var keyList = PyramidList.Keys.ToList();

            foreach (var key in keyList)
            {
                PyramidList[key].Add(1);
            }

            //foreach (var letter in PyramidList)
            //{
            //    Console.WriteLine($"{letter.Key} => {string.Join(", ", letter.Value)}");
            //}

            var maxPyramidic = PyramidList.OrderByDescending(n => n.Value.Count).First();

            foreach (var value in maxPyramidic.Value)
            {
                Console.WriteLine($"{new string(maxPyramidic.Key, value)}");
            }
        }
        else
        {
            Console.WriteLine(words[0][0]);
        }
       
    }

    private static bool ContainsMethod(char letter, int count, string word)
    {

        var check = false;
      
            if (word.Contains(new string(letter,count)))
            {
                check = true;
            }
       
        return check;
    }
}

