using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task02CommandInterpreter
{
    static void Main(string[] args)
    {

        var numbers = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        var input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        while (input[0] != "end")
        {
            switch (input[0])
            {
                case "reverse":
                    {
                        numbers = ReverseTheArray(numbers, input);
                        break;
                    }
                case "rollLeft":
                    {
                        numbers = RollLeftTheArray(numbers, input);
                        break;
                    }
                case "rollRight":
                    {
                        numbers = RollRightTheArray(numbers, input);
                        break;
                    }
                case "sort":
                    {
                        numbers = SortTheArray(numbers, input);
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }
            }

            input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        }

        Console.WriteLine("[{0}]", string.Join(", ", numbers));
    }

    private static List<string> RollRightTheArray(List<string> numbers, string[] input)
    {
        var count = int.Parse(input[1]);

        if (count < 0)
        {
            Console.WriteLine("Invalid input parameters.");

            return numbers;
        }

        count = count % numbers.Count;

        while (count > 0)
        {
            var temp = numbers[numbers.Count - 1];

            numbers.RemoveAt(numbers.Count - 1);

            numbers.Insert(0, temp);

            count--;
        }

        return numbers;
    }

    private static List<string> RollLeftTheArray(List<string> numbers, string[] input)
    {
        var count = int.Parse(input[1]);

        if (count<0)
        {
            Console.WriteLine("Invalid input parameters.");

            return numbers;
        }

        count = count % numbers.Count;

        while (count > 0)
        {
            var temp = numbers[0];

            numbers.RemoveAt(0);

            numbers.Add(temp);

            count--;
        }

        return numbers;
    }

    private static List<string> SortTheArray(List<string> numbers, string[] input)
    {
        var tempList = new List<string>();

        var startIndex = int.Parse(input[2]);

        var length = int.Parse(input[4]);

        if (startIndex < 0 || length < 0 || startIndex + length - 1 >= numbers.Count || startIndex == numbers.Count)
        {
            Console.WriteLine("Invalid input parameters.");

            return numbers;
        }

        numbers.Sort(startIndex,length,StringComparer.InvariantCulture);

        return numbers;
    }

    private static List<string> ReverseTheArray(List<string> numbers, string[] input)
    {

        var startIndex = int.Parse(input[2]);

        var length = int.Parse(input[4]);

        var endIndex = startIndex + length - 1;

        if (startIndex < 0 || length < 0 || startIndex + length - 1 >= numbers.Count || startIndex==numbers.Count)
        {
            Console.WriteLine("Invalid input parameters.");

            return numbers;
        }

        numbers.Reverse(startIndex,length);

        return numbers;
    }
}

