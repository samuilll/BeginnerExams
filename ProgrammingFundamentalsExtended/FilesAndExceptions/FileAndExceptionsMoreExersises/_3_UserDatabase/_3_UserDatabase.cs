using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class _3_UserDatabase
{
    static void Main(string[] args)
    {

        var usersStore = new Dictionary<string, User>();

        if (File.ReadAllText("registerList.txt")!=string.Empty)
        {
            var lines = File.ReadAllLines("registerList.txt");

            File.WriteAllText("registerList.txt",string.Empty);

            usersStore = FillTheDictionaryAccordingToTheFile(usersStore, lines);
        }


        bool loggedIn = false;

        var inputLine = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        while (inputLine[0] != "exit")
        {
            if (inputLine[0] == "register")
            {
                ReisterMethod(usersStore, inputLine);
            }
            else if (inputLine[0] == "login")
            {
                loggedIn = LogInMethod(usersStore, loggedIn, inputLine);
            }
            else
            {
                loggedIn = LogoutMethod(loggedIn);
            }

            inputLine = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        }

        FillTheFileWithInfo(usersStore);
    }

    private static Dictionary<string, User> FillTheDictionaryAccordingToTheFile(Dictionary<string, User> usersStore, string[] lines)
    {

        foreach (var line in lines)
        {
            var userName = line.Split('-').First();

            var pass = line.Split('-').Last();

            usersStore[userName] = new User(userName,pass);
        }

        return usersStore;
    }

    private static void FillTheFileWithInfo(Dictionary<string, User> usersStore)
    {
        foreach (var user in usersStore)
        {
            File.AppendAllText("registerList.txt", $"{user.Value.Username}-{user.Value.Password}" + Environment.NewLine);
        }
    }   

    private static bool LogoutMethod(bool loggedIn)
    {
        if (loggedIn)
        {
            loggedIn = false;
        }
        else
        {
            Console.WriteLine("There is no currently logged in user.");
        }

        return loggedIn;
    }

    private static bool LogInMethod(Dictionary<string, User> usersStore, bool loggedIn, List<string> inputLine)
    {
        var userName = inputLine[1];

        var pass = inputLine[2];

        if (loggedIn)
        {
            Console.WriteLine("There is already a logged in user.");
        }
        else if (!usersStore.ContainsKey(userName))
        {
            Console.WriteLine("There is no user with the given username.");
        }
        else if (pass != usersStore[userName].Password)
        {
            Console.WriteLine("The password you entered is incorrect.");
        }
        else
        {
            loggedIn = true;
        }

        return loggedIn;
    }

    private static void ReisterMethod(Dictionary<string, User> usersStore, List<string> inputLine)
    {
        var userName = inputLine[1];

        var pass = inputLine[2];

        var confirmedPass = inputLine[3];

        if (usersStore.ContainsKey(userName))
        {
            Console.WriteLine("The given username already exists.");
        }
        else if (pass != confirmedPass)
        {
            Console.WriteLine("The two passwords must match.");
        }
        else
        {
            usersStore[userName] = new User(userName, pass);
        }
    }
}

