using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class User
{
    public string Username { get; set; }

    public List<Message> ReceivedMessages { get; set; }

    public User(string userName, List<Message> messages)
    {
        this.Username = userName;

        this.ReceivedMessages = messages;
    }


}

