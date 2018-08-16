using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifications06
{
    class Notifications06
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                 string SuccessOrError = Console.ReadLine();
                if (SuccessOrError == "success")
                {
                    var operation = Console.ReadLine();
                    var Message = Console.ReadLine();
                    ShowSuccess(operation, Message);
                }
                else if (SuccessOrError == "error")
                {
                    var operation = Console.ReadLine();
                    var code = int.Parse(Console.ReadLine());
                    ShowError(operation, code);

                }
                else Console.WriteLine();

            }
        }
        static void ShowSuccess(string operation, string message)
            {
            
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");

            }
        static void ShowError(string operation, int code)
        {
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            if (code >= 0) Console.WriteLine("Reason: Invalid Client Data.");
            else Console.WriteLine("Reason: Internal System Failure.");

        }
    }
}
