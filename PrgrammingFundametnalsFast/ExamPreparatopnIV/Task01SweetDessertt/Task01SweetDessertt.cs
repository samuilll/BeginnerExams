using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01SweetDessertt
{
    class Task01SweetDessertt
    {
        static void Main(string[] args)
        {
            decimal ivanchosCash = decimal.Parse(Console.ReadLine());

            int guests = int.Parse(Console.ReadLine());

            decimal bananaPrice = decimal.Parse(Console.ReadLine());

            decimal eggPrice = decimal.Parse(Console.ReadLine());

            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            var numberofPortions = (guests % 6 == 0 ? (guests/6) : (guests/6+1));

            var nessesaryMoney =(decimal) (numberofPortions * (bananaPrice*2+eggPrice*4+berriesPrice/5));

            if (nessesaryMoney<=ivanchosCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {nessesaryMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(nessesaryMoney-ivanchosCash):f2}lv more.");
            }





        }
    }
}
//The amount of cash Ivancho has – decimaling-point number in range[0.00…1, 000, 000, 000.00]
//The number of guests – integer in range[0…1, 000, 000, 000]
//The price of bananas for a single unit – decimaling-point number in range[0.00…1, 000.00]
//The price of eggs for a single unit – decimaling-point number in range[0.00…1, 000.00]
//The price of berries for a kilo – decimaling-point number in range[0.00…1, 000.00]
