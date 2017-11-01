using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task04CubicMessages
{
    class Task04CubicMessages
    {
        static void Main(string[] args)
        {

            Regex regMessage = new Regex(@"^\d+(?<message>[a-zA-Z]+)[^a-zA-Z]*$");

            Regex regDigits = new Regex(@"\d");

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Over!")
                {
                    break;
                }

                var requiredLength = int.Parse(Console.ReadLine());

                if (!regMessage.IsMatch(input))
                {
                    continue;
                }

                var message = regMessage.Match(input).Groups["message"].Value;

                if (message.Length != requiredLength)
                {
                    continue;
                }


                var numbers = regDigits.Matches(input).Cast<Match>().Select(n => int.Parse(n.Value)).ToList();

                var result = ResultForPrint(message, numbers);

                Console.WriteLine(result);
            }
        }

        private static string ResultForPrint(string message, List<int> numbers)
        {
            var builder = new StringBuilder($"{message} == ");

            foreach (var number in numbers)
            {
                if (number >= 0 && number < message.Length)
                {
                    builder.Append(message[number]);
                }
                else
                {
                    builder.Append(" ");
                }
            }

            return builder.ToString();
        }
    }
}
