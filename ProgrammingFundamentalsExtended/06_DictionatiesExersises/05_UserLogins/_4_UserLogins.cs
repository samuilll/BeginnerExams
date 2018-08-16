using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _4_UserLogins
{
    static void Main(string[] args)
    {
        var inputUserAndPass = Console.ReadLine()
            .Split(new string[] { " ", "->" }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        var listedUsers = new Dictionary<string, string>();

        while (inputUserAndPass[0] != "login")
        {
            var user = inputUserAndPass[0];

            var password = inputUserAndPass[1];

            FillTheListWithUsersAndReferencedPasswords(listedUsers, user, password);

            inputUserAndPass = Console.ReadLine()
            .Split(new string[] { " ", "->" }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        }

        inputUserAndPass = Console.ReadLine()
            .Split(new string[] { " ", "->" }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        var unsuccessfullLogins = 0;

        while (inputUserAndPass[0] != "end")
        {
            var user = inputUserAndPass[0];

            var password = inputUserAndPass[1];

            unsuccessfullLogins = TryToLogIn(listedUsers, user, password,unsuccessfullLogins);

            inputUserAndPass = Console.ReadLine()
           .Split(new string[] { " ", "->" }, StringSplitOptions.RemoveEmptyEntries)
           .ToArray();
        }

        Console.WriteLine($"unsuccessful login attempts: {unsuccessfullLogins}");
    }

    private static int TryToLogIn(Dictionary<string, string> listedUsers, string user, string password,int unsuccsessfullLogins)
    {
        if (!listedUsers.ContainsKey(user))
        {
            Console.WriteLine($"{user}: login failed");

            unsuccsessfullLogins++;
        }
        else if (listedUsers[user]!=password)
        {
            Console.WriteLine($"{user}: login failed");

            unsuccsessfullLogins++;
        }
        else
        {
            Console.WriteLine($"{user}: logged in successfully");
        }

        return unsuccsessfullLogins;
    }

    private static void FillTheListWithUsersAndReferencedPasswords(Dictionary<string, string> listedUsers, string user, string password)
    {
        listedUsers[user] = password;
    }
}

