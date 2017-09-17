using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _5_StringCommander
{
    static void Main(string[] args)
    {
        var text = Console.ReadLine();

        var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        while (command[0] != "end")
        {
            switch (command[0])
            {
                case "Left":
                    {
                        var count = int.Parse(command[1]);
                        text = ImplementTheLeftFunction(text, count);
                        break;
                    }
                case "Right":
                    {
                        var count = int.Parse(command[1]);
                        text = ImplementTheRightFunction(text, count);
                        break;
                    }
                case "Delete":
                    {
                        var startIndex = int.Parse(command[1]);
                        var endIndex = int.Parse(command[2]);
                        text = ImplementTheLeftFunction(text, startIndex, endIndex);
                        break;
                    }
                case "Insert":
                    {
                        var index = int.Parse(command[1]);
                        string newWord = command[2];
                        text = ImplementTheLeftFunction(text, index, newWord);
                        break;
                    }
            }
            command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        }
        Console.WriteLine(text);
    }

    private static string ImplementTheLeftFunction(string text, int index, string newWord)
    {
        var builder = new StringBuilder(text);
     
        builder.Insert(index, newWord);

        return builder.ToString();
    }

    private static string ImplementTheLeftFunction(string text, int startIndex, int endIndex)
    {
        var builder = new StringBuilder(text);

        var length = endIndex - startIndex + 1;

        builder.Remove(startIndex,length);

        return builder.ToString();
    }

    private static string ImplementTheRightFunction(string text, int count)
    {
        var builder = new StringBuilder(text);

        for (int i = 0; i < count; i++)
        {
            builder.Insert(0,builder[builder.Length-1]);

            builder.Remove(builder.Length-1, 1);
        }

        return builder.ToString();
    }

    private static string ImplementTheLeftFunction(string text, int count)
    {
        var builder = new StringBuilder(text);

        for (int i = 0; i < count; i++)
        {
            builder.Append(builder[0]);
            builder.Remove(0, 1);
        }

        return builder.ToString();
   }
}

