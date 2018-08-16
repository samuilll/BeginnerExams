using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text;



class _3_BoomingCannon
    {
        static void Main(string[] args)
        {

        var distanceAndPower = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        var dictance = distanceAndPower[0];

        var power = distanceAndPower[1];

        var targetText = Console.ReadLine();

        var regex = new Regex(@"(?<=(\\<<<)).+?((?=\\)|$|(\s))");

        var matches = regex.Matches(targetText);

        var shots = new List<string>();

        foreach (Match match in matches)
        {
            var currentshot = ImplementTheShot(match.Value,dictance,power);

            if (currentshot!=string.Empty)
            {
                shots.Add(currentshot);

            }
        }


        Console.WriteLine(string.Join("/\\",shots));
        }

    private static string ImplementTheShot(string target, int dictance, int power)
    {
        var builder = new StringBuilder();

        var counter = 0;

        if (power>0)
        {
            for (int i = dictance; i < target.Length; i++)
            {
                builder.Append(target[i]);

                counter++;

                if (counter >= power)
                {
                    break;
                }
            }
        }
        

        return builder.ToString();
    }
}

