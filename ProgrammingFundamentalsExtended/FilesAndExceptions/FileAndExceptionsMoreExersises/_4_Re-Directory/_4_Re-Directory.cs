using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        var dirInfo = new DirectoryInfo("input");

        var files = dirInfo.GetFiles();

        var extensionsList = new HashSet<string>();

        foreach (var fileInfo in files)
        {
            extensionsList.Add(fileInfo.Extension.Split('.').Last() + "s");
        }

        Console.WriteLine(string.Join(" | ", extensionsList));

        Directory.CreateDirectory("output");

        foreach (var extensions in extensionsList)
        {

            Directory.CreateDirectory($"output/{extensions}");
        }

        foreach (var fileInfo in files)
        {
            File.Move($"input/{fileInfo.Name}",$"output/{fileInfo.Extension.Split('.').Last() + "s"}/{fileInfo.Name}");
        }


    }
}

