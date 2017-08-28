using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// <{tag}>{content}</{tag}> 
class _2_HTMLContents
{
    static void Main(string[] args)
    {

        var inputLine = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        var tagsStore = new List<string>();

        var title = string.Empty;

       
       //            File.Create("now.html");
        
      

        while (inputLine[0] != "exit")
        {
            if (inputLine[0] != "title")
            {
                var tag = inputLine[0];

                var content = inputLine[1];

                tagsStore.Add($"{"\t"}<{tag}>{content}</{tag}>");
            }
            else
            {
                title = inputLine[1];
            }

            inputLine = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        }

        string head = "\t" + $"<title>{title}</title>";

        File.AppendAllText("now.html", "<!DOCTYPE html>" + Environment.NewLine + "<html>" + Environment.NewLine + "<head>" + Environment.NewLine);

        File.AppendAllText("now.html", head + Environment.NewLine);

        File.AppendAllText("now.html", "/head" + Environment.NewLine + "<body>");

        foreach (var tag in tagsStore)
        {
            File.AppendAllText("now.html", tag);
        }

        File.AppendAllText("now.html", "</body>" + Environment.NewLine + "</html>");

    }
}

