using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    class _5_FolderSize
    {
        static void Main(string[] args)
        {
        var folder = Console.ReadLine();

        var newFolder = Console.ReadLine();

        var files = Directory.GetFiles(folder);

        double fullSize = 0;

        foreach (var file in files)
        {
            Console.WriteLine(file);

            

            var fileInfo = new FileInfo(file);

            var size = fileInfo.Length;

            Console.WriteLine(size);

            fullSize += size;
        }

        Console.WriteLine(fullSize/1024/1024);
        }
    }

