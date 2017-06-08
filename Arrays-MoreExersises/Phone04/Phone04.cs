using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook03
{
    class Phonebook03
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            string[] currentName = Console.ReadLine().Split(' ');
            while (currentName[0] != "done")
            {

                for (int i = 0; i < names.Length; i++)
                {
                    if (currentName[1] == names[i] && currentName[0] == "call")
                    {
                        var sum = GetTheSumOfTheDigits(phoneNumbers[i]);

                        if (sum%2!=0)
                        {
                            Console.WriteLine($"calling {phoneNumbers[i]}...\nno answer");
                        }
                        else
                        {
                            string time = TakeTimeFormat(sum);

                            Console.WriteLine($"calling {phoneNumbers[i]}...\ncall ended.duration: {time}");
                        }
                        
                      
                    }
                    if (currentName[1] == names[i] && currentName[0] == "message")

                    {
                        var difference = GetTheDigitsDifference(phoneNumbers[i]);

                        if (difference%2!=0)
                        {
                            Console.WriteLine($"sending sms to {phoneNumbers[i]}...\nbusy");
                        }
                        else
                        {
                            Console.WriteLine($"sending sms to {phoneNumbers[i]}...\nmeet me there");
                        }
                    }

                    if (currentName[1] == phoneNumbers[i] && currentName[0] == "call")
                    {
                        var sum = GetTheSumOfTheDigits(phoneNumbers[i]);

                        if (sum % 2 != 0)
                        {
                            Console.WriteLine($"calling {names[i]}...\nno answer");
                        }
                        else
                        {
                            string time = TakeTimeFormat(sum);

                            Console.WriteLine($"calling {names[i]}...\ncall ended. duration: {time}");
                        }


                    }
                    if (currentName[1] == phoneNumbers[i] && currentName[0] == "message")

                    {
                        var difference = GetTheDigitsDifference(phoneNumbers[i]);

                        if (difference % 2 != 0)
                        {
                            Console.WriteLine($"sending sms to {names[i]}...\nbusy");
                        }
                        else
                        {
                            Console.WriteLine($"sending sms to {names[i]}...\nmeet me there");
                        }
                    }

                }

                currentName = Console.ReadLine().Split();
            }
        }

        private static int GetTheDigitsDifference(string number)
        {
            var integer = Convert.ToInt64(number);

            

            Int64 difference = 0;

            while (integer != 0)
            {
                difference = integer % 10 + difference;

                integer /= 10;
            }
            return Convert.ToInt32(difference);
        }

        private static string TakeTimeFormat( int sum)
        {
            Convert.ToUInt64(sum);
            var min = sum / 60;
            var sec = sum % 60;
            string time = $"{min:D2}:{sec:D2}";
            return time;
            
        }

        private static int GetTheSumOfTheDigits(string number)
        {
            var integer = Convert.ToInt64(number);
           
            Int64 sum = 0;

            while(integer!=0)
            {
                sum = integer % 10 + sum;

                integer /= 10;
            }
            return Convert.ToInt32(sum);
        }
    }
}
//0888888888 0888123456 +359886001122

//Nakov Ivan Maria