using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class Merge
{
    static void Main(string[] args)
    {
        var first = File.ReadAllLines("first.txt");
        var second = File.ReadAllLines("second.txt");
        var i = 0;

        while (i < first.Length && i < second.Length)
        {
            File.AppendAllText("ouput.txt", first[i]+Environment.NewLine);
            File.AppendAllText("ouput.txt", second[i] + Environment.NewLine);
            i++;
        }
        while (i<first.Length)
        {
            File.AppendAllText("ouput.txt", first[i] + Environment.NewLine);
            i++;
        }
        while (i<second.Length)
        {
            File.AppendAllText("ouput.txt", second[i] + Environment.NewLine);
            i++;
        }

        foreach (var line in File.ReadAllLines("ouput.txt"))
        {
            Console.WriteLine(line);
        }

    }
}


