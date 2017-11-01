using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task03CameraView
{
    class Task03CameraView
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var toSkip = nums[0];

            var toTake = nums[1];

            Regex reg = new Regex(@"(?<=\|<).+?(?=\|<|\b)");

            var text = Console.ReadLine();

            var matches = reg.Matches(text).Cast<Match>().Select(n => n.Value).ToList();

            var output = new List<string>();

            foreach (var word in matches)
            {
                output.Add(string.Join("",word.ToCharArray().Skip(toSkip).Take(toTake)));
            }

            Console.WriteLine(string.Join(", ",output));
        }
    }
}
