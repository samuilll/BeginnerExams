using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task02ChangeList
{
    static void Main(string[] args)
    {

        var sequence = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var input = Console.ReadLine().Split();

        while (input[0] != "Odd" && input[0] != "Even")
        {
            switch (input[0])
            {
                case "Insert":
                    {
                        var index = int.Parse(input[2]);
                        var element = int.Parse(input[1]);
                        sequence.Insert(index, element);
                        break;
                    }
                case "Delete":
                    {
                        var element = int.Parse(input[1]);
                        for (int i = 0; i < sequence.Count; i++)
                        {
                            if (sequence[i] == element)
                            {
                                sequence.Remove(element);
                                i--;
                            }
                        }
                        break;
                    }
            }
            input = Console.ReadLine().Split();
        }

        if (input[0]=="Odd")
        {
            Console.WriteLine(string.Join(" ",sequence.Where(n=>n%2!=0)));
        }
        if (input[0] == "Even")
        {
            Console.WriteLine(string.Join(" ", sequence.Where(n => n % 2 == 0)));
        }

    }
}

