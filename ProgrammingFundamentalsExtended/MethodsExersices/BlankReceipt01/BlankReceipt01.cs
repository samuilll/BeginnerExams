using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankReceipt01
{
    class BlankReceipt01
    {
        static void Main(string[] args)
        {
            MainMethod();
        }
        static void Cash()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void ToWhom()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");

            static void Soft()
        {
                Console.WriteLine("------------------------------");
                Console.WriteLine("\u00a9 SoftUni");
            }
        static void MainMethod()
        {
            Cash(); ToWhom();Soft();
            
        }

    }
}
//CASH RECEIPT

//-- -- -- -- -- -- -- -- -- -- -- -- -- -- --

//Charged to____________________

//Received by___________________

//-- -- -- -- -- -- -- -- -- -- -- -- -- -- --

//© SoftUni

