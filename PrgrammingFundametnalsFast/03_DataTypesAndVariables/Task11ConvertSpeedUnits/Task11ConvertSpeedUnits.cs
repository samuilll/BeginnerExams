using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task11ConvertSpeedUnits
    {
        static void Main(string[] args)
        {

        int distance = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());

        float metersPrSecond =(float)distance/(hours*3600+minutes*60 + seconds) ;
        float kilometersPerHour = (distance/1000.0f)/(hours + (float)minutes/60 + (float)seconds/3600);
        float milesPerHour= (distance / 1609.0f) / (hours + (float)minutes / 60 + (float)seconds / 3600); ;

        Console.WriteLine(metersPrSecond);
        Console.WriteLine(kilometersPerHour);
        Console.WriteLine(milesPerHour);

    }
}

