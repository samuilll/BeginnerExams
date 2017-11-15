using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task03WormHole
    {
        static void Main(string[] args)
        {

        var wormArr = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var steps = 0;

        for (int i = 0; ; i++)
        {
            var check = false;
            if (i==wormArr.Length)
            {
                break;
            }
            if (wormArr[i]!=0)
            {
                var temp = wormArr[i];
                wormArr[i] = 0;
                i = temp;
                i--;
                check = true;
            }
            if (!check)
            {
                steps++;
            }
        }

        Console.WriteLine(steps);
        }
    }

