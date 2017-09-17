using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamShedule01
{
    class ExamShedule01
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine());
            int startMinute = int.Parse(Console.ReadLine());
            string AMOrPM = Console.ReadLine();
            int durationHours = int.Parse(Console.ReadLine());
            int durationMinutes = int.Parse(Console.ReadLine());

            var startInMinutes = startHour * 60 + startMinute;
            var durationInMinutes = durationHours * 60 + durationMinutes;
            var endInMinutes = startInMinutes + durationInMinutes;

            var endHour = endInMinutes / 60;
            var endMinute = endInMinutes % 60;
            var endAmOrPm = "";

            if (endHour >= 12)
            {
                if (endHour <= 24)
                {
                    if (AMOrPM == "AM")
                    {
                        endAmOrPm = "PM";
                        endHour = endHour - 12;

                        if (endHour == 0) endHour = 12;

                        Console.WriteLine("{0:D2}:{1:D2}:{2}", endHour, endMinute, endAmOrPm);
                    }

                    if (AMOrPM == "PM")
                    {

                        endAmOrPm = "AM";
                        endHour = endHour - 12;

                        if (endHour == 0) endHour = 12;

                        Console.WriteLine("{0:D2}:{1:D2}:{2}", endHour, endMinute, endAmOrPm);

                    }
                }
                else
                {
                   
                    endHour = endHour - 24;

                    

                    Console.WriteLine("{0:D2}:{1:D2}:{2}", endHour, endMinute, AMOrPM);
                }

            }

            else

                Console.WriteLine("{0:D2}:{1:D2}:{2}", endHour, endMinute, AMOrPM);

        }
    }
}
