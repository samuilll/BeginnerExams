using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SyntaxFileInfoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = new FileInfo("Gorgon.txt");

            Console.WriteLine(info.Name);
            Console.WriteLine(info.Name.Split('.')[0]);
            Console.WriteLine(info.Directory);
            Console.WriteLine(info.DirectoryName);

            var directoryInfo = info.Directory;

            var time = info.CreationTime;

            Console.WriteLine(time);

            Console.WriteLine(info.Length);

            Console.WriteLine(info.FullName);
        }
    }
}
