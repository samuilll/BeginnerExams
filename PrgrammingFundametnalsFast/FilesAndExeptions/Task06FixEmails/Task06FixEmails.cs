using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task07FixEmails
{
    static void Main(string[] args)
    {
        string name = string.Empty;

        string[] lines = File.ReadAllLines("input.txt");

        File.Delete("output.txt");

        int counter = 0;

        string outputFileName = string.Empty;

        var mailsBook = new Dictionary<string, string>();

        while (lines[counter] != "stop")
        {
            if (counter % 2 == 0)
            {
                name = lines[counter];
            }
            else
            {
                string mail = lines[counter];

                string country = mail.Substring(mail.Length - 2, 2);

                if (country != "us" && country != "uk")
                {
                    File.AppendAllText($"output.txt",$"{name} -> {mail}\r\n");
                }
            }

            counter++;

        }

      

    }
}