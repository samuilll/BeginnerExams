using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class _4_DeserializeString
    {
        static void Main(string[] args)
        {

        var line = Console.ReadLine().Split(':');

        var values = new Dictionary<char, List<int>>();

        while (line[0]!="end")
        {
            int[] indexers = line[1].Split('/').Select(int.Parse).ToArray();

            foreach (var index in indexers)
            {
                if (!values.ContainsKey(Convert.ToChar(line[0])))
                {
                    values[Convert.ToChar(line[0])] = new List<int>();
                }
                values[Convert.ToChar(line[0])].Add(index);

            }

            line = Console.ReadLine().Split(':');
        }

        //foreach (var pair in values)
        //{
        //    Console.WriteLine($"{pair.Key} => {string.Join("||",pair.Value)}");
        //}

        var maxIndex = values.Values.OrderByDescending(n=>n.Max()).First().Last();

    //    Console.WriteLine(maxIndex);

        char[] result = new char[maxIndex + 1];

    //    Console.WriteLine(result.Length);

        foreach (var symbolIndexers in values)
        {
            foreach (var index in symbolIndexers.Value)
            {
                result[index] = symbolIndexers.Key;
            }
        }

        Console.WriteLine(string.Join("",result));
        }
    }

