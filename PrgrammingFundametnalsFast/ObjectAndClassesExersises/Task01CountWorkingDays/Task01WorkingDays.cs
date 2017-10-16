using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task01CountWorkingDays
{
    class Task01WorkingDays
    {
        static void Main(string[] args)
        {

            DateTime startDay = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime endDay = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int year = startDay.Year;

            var counter = 0;

            var holidays = new DateTime[] {  new DateTime(year, 1, 1),   new DateTime(year, 3, 3), new DateTime(year, 5, 1),
                new DateTime(year, 5, 6),new DateTime(year, 5, 24),new DateTime(year, 9, 6),new DateTime(year, 9, 22),
                new DateTime(year, 11, 1),new DateTime(year, 12, 24),new DateTime(year, 12, 25),new DateTime(year, 12, 26)
            };

            for (var i = startDay; DateTime.Compare(i, endDay) <1; i = i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Sunday && i.DayOfWeek != DayOfWeek.Saturday)
                {
                    bool check = true;

                    foreach (var date in holidays)
                    {
                        if (date.Month == i.Month && date.Day == i.Day)
                        {
                            check = false;
                            break;
                        }
                    }

                    if (check)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);

        }
    }
}
//New Year Eve(1 Jan)
//Liberation Day(3 March)
//Worker’s day(1 May)
//Saint George’s Day(6 May)
//Saints Cyril and Methodius Day(24 May)
//Unification Day(6 Sept)
//Independence Day(22 Sept)
//National Awakening Day(1 Nov)
//Christmas(24, 25 and 26 Dec)
