using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Message
{
    public string Content { get; set; }

    public User Sender { get; set; }

    public Message(string content, User sender)
    {

        this.Content = content;

        this.Sender = sender;

    }
}