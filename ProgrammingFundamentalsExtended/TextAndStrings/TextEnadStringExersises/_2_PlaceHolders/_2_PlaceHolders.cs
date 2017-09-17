using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class PlaceHolders
    {
        static void Main(string[] args)
        {

        var inputLine = Console.ReadLine()
            .Split(new[] { '-','>' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        while (inputLine[0]!="end")
        {
            var text = inputLine[0];

            var words = inputLine[1]
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < text.Length-3; i++)
            {
 
                if (text[i]=='{'  && text[i+2]=='}')
                {
                    var number = int.Parse(text[i+1].ToString());
                    if (number<=words.Length-1)
                    {
                        text = text.Replace(text.Substring(i, 3), words[int.Parse(text[i + 1].ToString())]);
                    }
                }
            }

            Console.WriteLine(text);

            inputLine = Console.ReadLine()
                        .Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
        }
        }
    }

