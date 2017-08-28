using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    class _1_FilterExtensions
    {
        static void Main(string[] args)
        {

        var dirInfo = Directory.GetFiles("input");

        var requestedExtension = Console.ReadLine();

        foreach (var file in dirInfo)
        {
            var currentExtension = file.Split('.').Last();
            if (currentExtension==requestedExtension)
            {
                Console.WriteLine(file);
            }
      //      Console.WriteLine(file);
        }
        }
    }

