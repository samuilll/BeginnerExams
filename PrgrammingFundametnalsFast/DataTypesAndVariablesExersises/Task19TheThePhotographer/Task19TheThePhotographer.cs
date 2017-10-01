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

            int numberOfPictures = int.Parse(Console.ReadLine());

            int filterTime = int.Parse(Console.ReadLine());

            int filterFactor = int.Parse(Console.ReadLine());

            int uploadTimeForPicture = int.Parse(Console.ReadLine());

            int usefulPictures = (int)Math.Ceiling((double)filterFactor / 100 * numberOfPictures);

            int allUploadTime = uploadTimeForPicture * usefulPictures;

            int allTime = allUploadTime + filterTime * numberOfPictures;

            Console.WriteLine(usefulPictures);
            Console.WriteLine(allUploadTime);

            var days = allTime / 60/60/24;

            var hours = allTime/60/60;

            var minutes = allTime/60;

            var seconds = ((allTime % 86400) % 60) % 60;

            Console.WriteLine($"{days}:{hours:D2}:{minutes:d2}:{seconds:d2}");

        }
    }
}
