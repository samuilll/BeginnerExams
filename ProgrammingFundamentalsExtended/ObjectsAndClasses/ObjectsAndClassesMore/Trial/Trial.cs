using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class User
{
    public string Username { get; set; }

    public List<string> ReceivedMessages { get; set; }

    public static User ParseName(string input)
    {
        var currentUser = new User();

        currentUser.Username = input;

        return currentUser;
    }
}

class Trial
{
    static void Main(string[] args)
    {
        var user = new User() { Username = "ferifica" };

        Console.WriteLine(user.Username);

        var check = user.ReceivedMessages != null;

        Console.WriteLine(check);

    }
}

//DSK | Ivan | 504,403
//DSK | Pesho | 2000,4031
//DSK | Aleksander | 20000,0001
//Piraeus | Ivan | 504,403
//Piraeus | Aleksander | 20000,0001