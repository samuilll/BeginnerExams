using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
class Fish
{

    public string Form { get; set; }

    public int Tail { get; set; }

    public int Body { get; set; }

    public string Condition()
    {
        switch (Form[Form.Length - 2])
        {
            case '-':
                {
                    return "Asleep";
                    break;
                }
            case 'x':
                {
                    return "Dead";
                    break;
                }
            case '\'':
                {
                    return "Awake";
                    break;
                }

            default: return "None";
        }
    }

    public string KindOfTail()
    {

        if (Tail == 0)
        {
            return "None";
        }
        else if (Tail == 1)
        {
            return "Short";
        }
        else if (Tail <= 5)
        {
            return "Medium";
        }
        else
        {
            return "Long";
        }
    }

    public string KindOfBody()
    {

        if (Body > 10)
        {
            return "Long";
        }
        else if (Body > 5)
        {
            return "Medium";
        }
        else
        {
            return "Short";
        }
    }

    public Fish(string form, int tail, int body)
    {
        this.Form = form;

        this.Tail = tail;

        this.Body = body;
    }


}


class _6_FishStatistics
    {
        static void Main(string[] args)
        {

        var line = Console.ReadLine();

        var regex = new Regex(@"(?<tail>>*)<(?<body>\(+?)(?<condition>['-x])>");

        var matches = regex.Matches(line);

        var i = 0;

        if (matches.Count>0)
        {
            foreach (Match fish in matches)
            {
                var form = fish.Value;

                var tail = fish.Groups["tail"].Value.Length;

                var body = fish.Groups["body"].Value.Length;

                var currentFish = new Fish(form, tail, body);

                Console.WriteLine($"Fish {++i}: {currentFish.Form}");
                if (tail == 0)
                {
                    Console.WriteLine($"  Tail type: {currentFish.KindOfTail()}");
                }
                else
                {
                    Console.WriteLine($"  Tail type: {currentFish.KindOfTail()} ({tail * 2} cm)");
                }
                Console.WriteLine($"  Body type: {currentFish.KindOfBody()} ({body * 2} cm)");
                Console.WriteLine($"  Status: {currentFish.Condition()}");
            }
        }
        else
        {
            Console.WriteLine("No fish found.");
        }



    }
    }

//Fish 1: &gt;&lt;((((&#39;&gt;><(((('>

//Tail type: Short(2 cm)
//Body type: Short(8 cm)
//Status: Awake