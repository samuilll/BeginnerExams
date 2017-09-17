using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



class _7_HappinessIndex
    {
    static void Main(string[] args)
    {

        var line = Console.ReadLine();

        var happyRegex = new Regex(@"(:\))|(:D)|(;\))|(:\*)|(:])|(;])|(:})|(;})|(\(:)|(\*:)|(c:)|(\[:)|(\[;)");

        var sadRegex = new Regex(@"(:\()|(D:)|(;\()|(:\[)|(;\[)|(:{)|(;{)|(\):)|(:c)|(]:)|(];)");

        var happyEmoti = happyRegex.Matches(line).Cast<Match>().Select(n => n.Value).ToList();

        var sadEmoti = sadRegex.Matches(line).Cast<Match>().Select(n => n.Value).ToList();

        var happynessIndex = Convert.ToDecimal(happyEmoti.Count) / sadEmoti.Count;

        var emoticon = string.Empty;

        if (happynessIndex>=2)
        {
            emoticon = ":D";
        }
        else if (happynessIndex>1)
        {
            emoticon = ":)";
        }
        else if (happynessIndex==1)
        {
            emoticon = ":|";
        }
        else
        {
            emoticon = ":(";

        }

        Console.WriteLine($"Happiness index: {happynessIndex:f2} {emoticon}");
        Console.WriteLine($"[Happy count: {happyEmoti.Count}, Sad count: {sadEmoti.Count}]");

    }
}

