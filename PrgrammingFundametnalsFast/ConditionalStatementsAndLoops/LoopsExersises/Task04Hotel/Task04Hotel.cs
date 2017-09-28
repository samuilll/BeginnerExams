using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task04Hotel
{
    static void Main(string[] args)
    {

        var month = Console.ReadLine();

        var nights = int.Parse(Console.ReadLine());

        var studioPrice = 0.0;

        var doublePrice = 0.0;

        var suitePrice = 0.0;

        var studioPerNight = 0;

        var doublePerNight = 0;

        var suitePerNight = 0;

        switch (month)
        {
            case "May":
            case "October":
                
                    studioPerNight = 50;

                    doublePerNight = 65;

                    suitePerNight = 75;

                    break;
                
            case "June":
            case "September":
        
                    studioPerNight = 60;

                    doublePerNight = 72;

                    suitePerNight = 82;

                break;
                
            case "July":
            case "August":
            case "December":
                
                    studioPerNight = 68;

                    doublePerNight = 77;

                    suitePerNight = 89;

                    break;
         
        }

        studioPrice = studioPerNight * nights;
        doublePrice = doublePerNight * nights;
        suitePrice = suitePerNight * nights;

        if (nights>7)
        {
            
            if (month == "September" || month == "October")
            {
                studioPrice -= studioPerNight;
            }
            if (month == "May" || month == "October")
            {
                studioPrice = studioPrice - (5 * studioPrice / 100);
            }
        }
        if (nights>14)
        {
            if (month == "September" || month == "June")
            {
                doublePrice = doublePrice - (10*doublePrice/100);
            }
            if (month == "July" || month == "August" || month=="December")
            {
                suitePrice = suitePrice - (15 * suitePrice / 100);
            }
        }

        Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        Console.WriteLine($"Double: {doublePrice:f2} lv.");
        Console.WriteLine($"Suite: {suitePrice:f2} lv.");


    }
}   

