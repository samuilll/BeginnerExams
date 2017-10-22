using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task02
{
    class Broadcast
    {

        public string Frequency { get; set; }

        public string Message { get; set; }

    }
    class Message
    {

        public string Text { get; set; }

        public string Recipient { get; set; }

    }
    class Task02
    {
        static void Main(string[] args)
        {

            List<Broadcast> broadcastList = new List<Broadcast>();

            List<Message> messagesList = new List<Message>();

            Regex broadcastRegex = new Regex(@"^(?<message>[^0-9]+) <-> (?<frequency>\w+)$");

            Regex messageRegex = new Regex(@"^(?<recipient>[0-9]+) <-> (?<message>\w+)$");

            var input = Console.ReadLine();


            while (input != "Hornet is Green")
            {
                if (broadcastRegex.IsMatch(input))
                {
                    string message = broadcastRegex.Match(input).Groups["message"].Value;

                    string frequency = broadcastRegex.Match(input).Groups["frequency"].Value;

                    frequency = ChangeTheLetters(frequency);

                    broadcastList.Add(new Broadcast { Message = message, Frequency = frequency });
                }
                else if (messageRegex.IsMatch(input))
                {
                    string recipient = messageRegex.Match(input).Groups["recipient"].Value;

                    recipient = ReverseAString(recipient);

                    string message = messageRegex.Match(input).Groups["message"].Value;

                    messagesList.Add(new Message { Text = message, Recipient = recipient });
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");

            if (broadcastList.Count!=0)
            {
                foreach (var broadcast in broadcastList)
                {
                    Console.WriteLine($"{broadcast.Frequency} -> {broadcast.Message}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            
            Console.WriteLine("Messages:");

            if (messagesList.Count!=0)
            {
                foreach (var message in messagesList)
                {
                    Console.WriteLine($"{message.Recipient} -> {message.Text}");
                }

            }
            else
            {
                Console.WriteLine("None");
            }

        }

        private static string ChangeTheLetters(string frequency)
        {
            StringBuilder built = new StringBuilder();

            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i]>='a' && frequency[i]<='z')
                {
                    built.Append(Char.ToUpper(frequency[i]));
                }

                else if (frequency[i] >= 'A' && frequency[i] <= 'Z')
                {
                    built.Append(Char.ToLower(frequency[i]));
                }
                else
                {
                    built.Append(frequency[i]);
                }
            }

            return built.ToString();
        }

        private static string ReverseAString(string recipient)
        {
            StringBuilder built = new StringBuilder();

            for (int i = recipient.Length - 1; i >= 0; i--)
            {
                built.Append(recipient[i]);
            }


            return built.ToString();
        }
    }
}
