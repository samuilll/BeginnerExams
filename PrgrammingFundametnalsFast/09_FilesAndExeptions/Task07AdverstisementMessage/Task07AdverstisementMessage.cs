using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task02AdvertisementMessage
{
    static void Main(string[] args)
    {
        var lines = File.ReadAllLines("input.txt");

        File.Delete("output.txt");

        int howManyTimes = int.Parse(lines[0]);

        Random r = new Random();

        string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.",
            "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

        string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

        string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

        string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        for (int i = 0; i < howManyTimes; i++)
        {
            var phrase = phrases[r.Next(0, 6)];

            var eventt = events[r.Next(0, 6)];

            var author = authors[r.Next(0, 8)];

            var city = cities[r.Next(0, 5)];

            File.AppendAllText("output.txt",$"{phrase} {eventt} {author} – {city}\r\n");
        }
    }
}