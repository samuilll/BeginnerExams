using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    class _2_LineNumbers
    {
        static void Main(string[] args)
        {

        var lines = File.ReadAllLines("ole.txt");

        var i = 1;

        foreach (var line in lines)
        {
            File.AppendAllText("olele.txt",$"{i}. {line}{Environment.NewLine}");

            i++;
        }
        }
    }

