using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task04Files
{

    class File
    {

        public string FullName { get; set; }

        public string Extension { get; set; }

        public decimal Size { get; set; }

        public File(string ful, string ex, decimal size)
        {
            this.FullName = ful;
            this.Size = size;
            this.Extension = ex;
        }
    }
    class Task04Files
    {
        static void Main(string[] args)
        {

            var N = int.Parse(Console.ReadLine());

            var dataBase = new Dictionary<string, List<File>>();

            Regex reg = new Regex(@"(?<root>.+?)\\(.+\\)*(?<fileext>(?<file>.+)\.(?<ext>.+));(?<size>\d+)");

            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine();

                if (reg.IsMatch(input))
                {


                    var match = reg.Match(input);

                    var root = match.Groups["root"].Value;

                    var extension = match.Groups["ext"].Value;

                    var fullFileName = match.Groups["fileext"].Value;

                    var size = decimal.Parse(match.Groups["size"].Value);

                    if (!dataBase.ContainsKey(root))
                    {
                        dataBase[root] = new List<File>();
                    }

                    if (dataBase[root].Where(n => n.FullName == fullFileName).Any())
                    {
                        dataBase[root].Remove(dataBase[root].Where(n => n.FullName == fullFileName).First());
                    }

                    dataBase[root].Add(new File(fullFileName, extension, size));
                }
            }

            var splitInput = Console.ReadLine().Split();

            var ext = splitInput[0];

            var searchedRoot = splitInput[2];

            var check= false;

            foreach (var pair in dataBase.Where(n=>n.Key== searchedRoot))
            {
                foreach (var file in pair.Value.Where(n => n.Extension == ext).OrderByDescending(n=>n.Size).ThenBy(n=>n.FullName))
                {
                    {
                        Console.WriteLine($"{file.FullName} - {file.Size} KB ");
                        check = true;
                    }
                }
            }
            if (!check)
            {
                Console.WriteLine("No");
            }
           
        }
    }
}


//  (?<file>.+)\.(?<ext>.+);(?<size>\d+)