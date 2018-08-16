using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownLoadre02
{
    class TrackDownLoadre02
    {
        static void Main(string[] args)
        {
            var blackList = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .ToList();

            var files = new List<string>();

            var outputFiles = new List<string>();

            var text = Console.ReadLine();

            while (text != "end")
            {

                var check = IgnoreTheExeptions(text, blackList);

                if (check)
                {
                    outputFiles.Add(text);
                }

                text = Console.ReadLine();

            }

            outputFiles.Sort();

            Console.WriteLine(string.Join(System.Environment.NewLine, outputFiles));

        }

        private static bool IgnoreTheExeptions(string text, List<string> blackList)
        {
            var check = true;

            for (int j = 0; j < blackList.Count; j++)
            {
                if (text.Contains(blackList[j]))
                {
                    check = false;

                    break;
                }
            }

            return check;
        }
    }
}
