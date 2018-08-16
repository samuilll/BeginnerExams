using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


    class _6_ReplaceTag
    {
        static void Main(string[] args)
        {
        var text = Console.ReadLine();

        var pattern = @"<a.*?href=(.*?)>(.*?)<\/a>";

        var regex = new Regex(pattern);

        var replacement = @"[URL href=$1]$2[/URL]";

        while (text!="end")
        {
            text = regex.Replace(text,replacement);

            Console.WriteLine(text);

            text = Console.ReadLine();
        }
        
    }
    }

