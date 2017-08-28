using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class SyntaxExceptions
{
    static void Main(string[] args)
    {


        try
        {

            var lines = File.ReadAllLines("input.txt");

            int num = 0;

            int p = 100;

            Console.WriteLine(lines[0]);

            Console.WriteLine(p / num);

        }
        catch (IOException ex)
        {
            Console.WriteLine("There is no such a file man! Try to focus your efforts better!");
            //  Console.WriteLine(ex.StackTrace);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("There Is A Problem With The Array's Length");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("You Cannot didve by zero man");
            Console.WriteLine(e.StackTrace);
        }
        finally // the block will awlays be executed
        {
            Console.WriteLine("bum-bum-bum-tra-ta-ta");
        }
    }
}

