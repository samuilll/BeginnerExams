using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Trial
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            var date = DateTime.ParseExact(input, "dd-MMM-yyyy",CultureInfo.InvariantCulture);

            Console.WriteLine(date.AddMonths(1).ToString("dd-MMM-yyyy"));
        }
    }
}
