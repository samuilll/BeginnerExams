using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task02ArrayManipulator
{
    static void Main(string[] args)
    {

        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        while (true)
        {
            var commandLine = Console.ReadLine();

            if (commandLine == "end")
            {
                break;
            }
            ProcceedTheCommand(commandLine, numbers);
        }

        Console.WriteLine("[{0}]", string.Join(", ", numbers));
    }

    private static void ProcceedTheCommand(string commandLine, List<int> numbers)
    {
        var commandSplit = commandLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        switch (commandSplit[0])
        {
            case "exchange":
                {
                    ImplementTheExchangeFunction(numbers, commandSplit);
                    break;
                }
            case "max":
                {
                    ImplementTheMaxFunction(numbers, commandSplit);
                    break;
                }
            case "min":
                {
                    ImplementTheMinFunction(numbers, commandSplit);
                    break;
                }
            case "first":
                {
                    ImplementTheFirstFunction(numbers, commandSplit);
                    break;
                }
            case "last":
                {
                     ImplementTheLastFunction(numbers, commandSplit);
                    break;
                }
            default:
                break;
        }
    }

    private static void ImplementTheLastFunction(List<int> numbers, string[] commandSplit)
    {
        var tempList = new List<int>();

        var count = int.Parse(commandSplit[1]);

        var commandCase = commandSplit[2];

        if (count > numbers.Count || count<0)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        if (commandCase == "odd")
        {
            for (int i = numbers.Count-1; i >= 0; i--)
            {
                if (numbers[i] % 2 != 0 && count > 0)
                {
                    tempList.Add(numbers[i]);
                    count--;
                }
            }
        }
        else
        {
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 0 && count > 0)
                {
                    tempList.Add(numbers[i]);
                    count--;
                }
            }
        }
        tempList.Reverse();

        Console.WriteLine("[{0}]",string.Join(", ", tempList));
    }

    private static void ImplementTheFirstFunction(List<int> numbers, string[] commandSplit)
    {
        var tempList = new List<int>();

        var count = int.Parse(commandSplit[1]);

        var commandCase = commandSplit[2];

        if (count>numbers.Count || count < 0)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        if (commandCase=="odd")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]%2!=0 && count>0)
                {
                    tempList.Add(numbers[i]);
                    count--;
                }
            }
        }
        else
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0 && count > 0)
                {
                    tempList.Add(numbers[i]);
                    count--;
                }
            }
        }
        Console.WriteLine("[{0}]",string.Join(", ",tempList));
    }

    private static void ImplementTheMinFunction(List<int> numbers, string[] commandSplit)
    {
        var minIndex = -1;

        var minNumber = int.MaxValue;

        var check = false;

        if (commandSplit[1] == "odd")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0 && numbers[i] <= minNumber)
                {
                    minIndex = i;
                    minNumber = numbers[i];
                    check = true;
                }
            }
        }
        else
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] <= minNumber)
                {
                    minIndex = i;
                    minNumber = numbers[i];
                    check = true;
                }
            }
        }
        if (check)
        {
            Console.WriteLine(minIndex);
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }

    private static void ImplementTheMaxFunction(List<int> numbers, string[] commandSplit)
    {
        var maxIndex = -1;

        var maxNumber = int.MinValue;

        var check = false;

        if (commandSplit[1] == "odd")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0 && numbers[i] >= maxNumber)
                {
                    maxIndex = i;
                    maxNumber = numbers[i];
                    check = true;
                }
            }
        }
        else
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] >= maxNumber)
                {
                    maxIndex = i;
                    maxNumber = numbers[i];
                    check = true;
                }
            }
        }
        if (check)
        {
            Console.WriteLine(maxIndex);
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }

    private static void ImplementTheExchangeFunction(List<int> numbers, string[] commandSplit)
    {
        var splitIndex = int.Parse(commandSplit[1]);

        var tempList = numbers.Take(splitIndex + 1).ToList();

        if (splitIndex >= numbers.Count || splitIndex < 0)
        {
            Console.WriteLine("Invalid index");
            return;
        }

        numbers.RemoveRange(0, splitIndex + 1);

        numbers.AddRange(tempList);
    }
}

