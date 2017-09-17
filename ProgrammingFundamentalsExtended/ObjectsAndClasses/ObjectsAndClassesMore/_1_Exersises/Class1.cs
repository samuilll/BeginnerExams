using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exersise
{

    public string Topic { get; set; }

    public string CourseName { get; set; }

    public string JudgeContestLink { get; set; }

    public List<string> Problems { get; set; }

    public static Exersise Parse(string inputLine)
    {
        var Ex = new Exersise();

        var separateFirst = inputLine
            .Split(new char[] { '}', '{', ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
            .Take(3)
            .ToList();

        var separateSecond = inputLine
           .Split(new char[] { '}', '{', ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries)
           .Skip(3)
           .ToList();

        Ex.Topic = separateFirst[0];

        Ex.CourseName = separateFirst[1];

        Ex.JudgeContestLink = separateFirst[2];

        Ex.Problems = separateSecond;

        return Ex;
    }

}



