using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task02LadyBugs
{
    static void Main(string[] args)
    {

        long fieldSize = long.Parse(Console.ReadLine());

        long[] field = new long[fieldSize];

        long[] ladybugsPlaces = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToArray();

        PlaceTheLadyBugs(field, ladybugsPlaces);

        while (true)
        {
            var command = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (command[0] == "end")
            {
                break;
            }

            ReadTheCommand(field, command);
        }

        Console.WriteLine(string.Join(" ", field));
    }

    private static void ReadTheCommand(long[] field, string[] command)
    {
        var direction = command[1];

        switch (direction)
        {
            case "left":
                {
                    LeftFunction(field, command);
                    break;
                }
            case "right":
                {
                    RightFunction(field, command);
                    break;
                }
            default:
                break;
        }
    }

    private static void RightFunction(long[] field, string[] command)
    {
        var bugIndex = long.Parse(command[0]);

        if (bugIndex < 0 || bugIndex >= field.Length)
        {
            return;
        }
        if (field[bugIndex] == 0)
        {
            return;
        }


        var flyLength = long.Parse(command[2]);

        long newIndex = bugIndex + flyLength;

        field[bugIndex] = 0;

        while (newIndex != -1)
        {
            newIndex = GetTheNewIndexRight(newIndex, flyLength, field);
        }

    }

    private static long GetTheNewIndexRight(long newIndex, long flyLength, long[] field)
    {
        if (newIndex >= 0 && newIndex < field.Length)
        {
            if (field[newIndex] == 1)
            {
                return newIndex + flyLength;
            }
            else
            {
                field[newIndex] = 1;

                return -1;
            }
        }
        else
        {
            return -1;
        }
    }

    private static void LeftFunction(long[] field, string[] command)
    {

        var bugIndex = long.Parse(command[0]);

        if (bugIndex < 0 || bugIndex >= field.Length)
        {
            return;
        }
        if (field[bugIndex] == 0)
        {
            return;
        }

        var flyLength = long.Parse(command[2]);

        long newIndex = bugIndex - flyLength;

        field[bugIndex] = 0;

        while (newIndex != -1)
        {
            newIndex = GetTheNewIndexLeft(newIndex, flyLength, field);
        }
    }

    private static long GetTheNewIndexLeft(long newIndex, long flyLength, long[] field)
    {
        if (newIndex >= 0 && newIndex < field.Length)
        {
            if (field[newIndex] == 1)
            {
                return newIndex - flyLength;
            }
            else
            {
                field[newIndex] = 1;

                return -1;
            }
        }
        else
        {
            return -1;
        }
    }

    private static void PlaceTheLadyBugs(long[] field, long[] ladybugsPlaces)
    {
        foreach (var bugIndex in ladybugsPlaces)
        {
            if (bugIndex >= 0 && bugIndex < field.Length)
            {
                field[bugIndex] = 1;
            }
        }
    }
}

