using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task06AMinersTask
{
    static void Main(string[] args)
    {


        var lines = File.ReadAllLines("input.txt");

        File.Delete("output.txt");

        Dictionary<string, int> resoursesBook = new Dictionary<string, int>();

        string resourse = string.Empty;

        int quantity = 0;

        for (int i = 0; ; i++)
        {
            if (resourse == "stop")
            {
                break;
            }
            if (i % 2 == 0)
            {
                resourse = lines[i];
            }
            else
            {
                quantity = int.Parse(lines[i]);

                if (!resoursesBook.ContainsKey(resourse))
                {
                    resoursesBook[resourse] = 0;

                }
                resoursesBook[resourse] += quantity;
            }
        }

        foreach (var good in resoursesBook)
        {
            File.AppendAllText("output.txt",$"{good.Key} -> {good.Value}\r\n");
        }
    }
}