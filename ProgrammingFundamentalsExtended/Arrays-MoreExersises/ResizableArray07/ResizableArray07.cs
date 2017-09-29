using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResizableArray07
{
    class ResizableArray07
    {
        static void Main(string[] args)
        {
            string origin = string.Empty;

            string[] input = string.Empty.Split();

            do
            {
                input = Console.ReadLine().Split();
                
                if (input[0] == "push")
                {
                    origin = ImplementThePushFunction(origin, input);
                }

                if (input[0] == "pop" && origin != "")
                {
                    origin = ImplementThePopFunction(origin);
                }

                if (input[0] == "removeAt")
                {
                 origin =   ImplementTheRemoveFunction(origin, input);
                }

                if (input[0] == "clear")
                {
                    origin = String.Empty;
                }

                //if (origin != "")

                //    Console.WriteLine(origin);

                //else Console.WriteLine("empty array");

            } while (input[0] != "end");

            if (origin != "")

                Console.WriteLine(origin);

            else Console.WriteLine("empty array");
        }

        private static string ImplementTheRemoveFunction(string origin, string[] input)
        {
            origin = origin.Trim();
            
            string[] srt3 = origin.Split(' ');

            origin = null;

            var index = int.Parse(input[1]);

            for (int i = 0; i < index; i++)
            {
                origin += srt3[i] + ' ';
            }

            for (int i = index+1; i < srt3.Length; i++)
            {
                origin += srt3[i] + ' ';
            }

            return origin;
        }

        private static string ImplementThePushFunction(string origin, string[] input)
        {
            origin += input[1] + ' ';

            return origin;
        }



        private static string ImplementThePopFunction(string origin)
        {
            var index = 0;

            origin = origin.Trim();

            string help = string.Empty;

            for (int i = origin.Length - 1; ; i--)   // Get the ' ' index to remove the last number 
            {

                if (origin[i] == ' ' || (i == 0))
                {
                    index = i;

                    break;
                }

            }

            if (index == 0)    // When the string has only one number

            {
                origin = "";
            }

            else                 // Whe the string has more than one number
            {

                for (int i = 0; i <= index; i++)
                {
                    help += origin[i];
                }

                origin = null;

                for (int i = 0; i < help.Length; i++)
                {
                    origin += help[i];
                }
            }
            return origin;
        }
    }
}
