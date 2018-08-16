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
            string[] command = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.None)
            .ToArray();

            if (command[0] == "end")
            {
                break;
            }

            ReadTheCommand(field, command);

          //  Console.WriteLine(string.Join(" ", field));

        }
        if (field.Length!=0)
        {
                    Console.WriteLine(string.Join(" ",field));
        }
    }

    private static void ReadTheCommand(long[] field, string[] command)
    {
        var direction = command[1];

        if (CheckTheParams(command))
        {
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
    }

    private static bool CheckTheParams(string[] command)
    {
        if (!long.TryParse(command[0],out long p))
        {
            return false;
        }
        if (!long.TryParse(command[2], out long f))
        {
            return false;
        }

        return true;
    }

    private static void RightFunction(long[] field, string[] command)
    {
        var bugIndex = long.Parse(command[0]);

        if (bugIndex < 0 || bugIndex >= field.Length)
        {
            return;
        }
        if (field[bugIndex]==0)
        {
            return;
        }

        var flyLength = long.Parse(command[2]);

        long newIndex = bugIndex+flyLength;

        field[bugIndex] = 0;

        while (true)
        {
            if (newIndex < 0 || newIndex >= field.Length)
            {
                break;
            }
            else if (field[newIndex] == 1)
            {
                newIndex += flyLength;
                continue;
            }
            else if (field[newIndex] == 0)
            {
                field[newIndex] = 1;
                break;
            }
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

        while (true)
        {
            if (newIndex < 0 || newIndex >= field.Length)
            {
                break;
            }
            else if (field[newIndex] == 1)
            {
                newIndex -= flyLength;
                continue;
            }
            else if (field[newIndex] == 0)
            {
                field[newIndex] = 1;
                break;
            }
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

