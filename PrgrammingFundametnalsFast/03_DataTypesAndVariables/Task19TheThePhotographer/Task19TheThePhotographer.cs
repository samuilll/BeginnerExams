using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19TheThePhotographer
{
    class Task19TheThePhotographer
    {
        static void Main(string[] args)
        {

            long numberOfPictures = long.Parse(Console.ReadLine());

            long filterTime = long.Parse(Console.ReadLine());

            long filterFactor = long.Parse(Console.ReadLine());

            long uploadTimeForPicture = long.Parse(Console.ReadLine());

            long usefulPictures = (long)Math.Ceiling((double)filterFactor / 100 * numberOfPictures);

            long allUploadTime = uploadTimeForPicture * usefulPictures;

            long allTime = allUploadTime + filterTime * numberOfPictures;

           //Console.WriteLine(usefulPictures);
           // Console.WriteLine(allUploadTime);
           // Console.WriteLine(allTime);


            long days = allTime / 60 / 60 / 24;

            long hours = (allTime / 60 / 60) % 24;

            long minutes = (allTime / 60) % 60;

            long seconds = allTime % 60;

            Console.WriteLine($"{days}:{hours:D2}:{minutes:d2}:{seconds:d2}");

        }
    }
}
