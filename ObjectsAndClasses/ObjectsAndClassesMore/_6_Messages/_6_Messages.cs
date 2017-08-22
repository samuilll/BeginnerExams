using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




class _6_Messages
{
    static void Main(string[] args)
    {

        var inputLine = Console.ReadLine();

        var usersList = new Dictionary<string, User>();

        while (inputLine != "exit")
        {
            var lenght = inputLine
           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .ToArray()
           .Length;

            var separate = inputLine
           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .ToArray();

            if (lenght == 2)
            {
                var currentUser = new User(separate[1], new List<Message>());

                usersList[separate[1]] = currentUser;
            }
            else
            {
                var recipient = new User(separate[2], new List<Message>());

                var sender = new User(separate[0], new List<Message>());

                var content = separate[3];

                var currentMessage = new Message(content, sender);

                if (usersList.ContainsKey(separate[2]) && usersList.ContainsKey(separate[0]))
                {

                    currentMessage.Sender = usersList[separate[0]];

                    usersList[separate[2]].ReceivedMessages.Add(currentMessage);
                }


            }

            inputLine = Console.ReadLine();
        }

        var names = Console.ReadLine()
           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .ToArray();

        var firstName = names[0];

        var secondName = names[1];

        PrintTheResult(usersList, firstName, secondName);

        //     PrintTheResultSecond(usersList, firstName, secondName);

    }




    private static void PrintTheResult(Dictionary<string, User> usersList, string firstName, string secondName)
    {
        var firstNameReceived = usersList[firstName].ReceivedMessages.Where(n => n.Sender.Username == secondName).ToList();

        var secondNameReceived = usersList[secondName].ReceivedMessages.Where(n => n.Sender.Username == firstName).ToList();

        var check = firstNameReceived.Count > secondNameReceived.Count;

        var index = 0;

        var isThereMessages = false;

        while (index < secondNameReceived.Count && index < firstNameReceived.Count)
        {
            Console.WriteLine($"{firstName}: {secondNameReceived[index].Content}");

            Console.WriteLine($"{firstNameReceived[index].Content} :{secondName}");

            index++;

            isThereMessages = true;
        }
        while (index < secondNameReceived.Count)
        {
            Console.WriteLine($"{firstName}: {secondNameReceived[index].Content}");

            index++;

            isThereMessages = true;
        }
        while (index < firstNameReceived.Count)
        {
            Console.WriteLine($"{firstNameReceived[index].Content} :{secondName}");

            index++;

            isThereMessages = true;
        }

        if (!isThereMessages)
        {
            Console.WriteLine("No messages");
        }
    }
}


