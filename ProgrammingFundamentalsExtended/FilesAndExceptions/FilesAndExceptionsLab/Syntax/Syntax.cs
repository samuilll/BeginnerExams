using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    class Syntax
    {
        static void Main(string[] args)
        {

        //-------------------ReadingAFileAsString------------------------1.

        Console.WriteLine("1.");

        string file = File.ReadAllText("Trial.txt");

        Console.WriteLine(file);

            Console.WriteLine();

        //---------------------ReadingAFileAsArrayOfStrings-----------------------
        Console.WriteLine("2.");

        string[] lines = File.ReadAllLines("Trial.txt");

        Console.WriteLine(lines[5]);
        Console.WriteLine();

        Console.WriteLine(string.Join("->",lines));
        Console.WriteLine();

        //--------------ReadingAFileInBackPathDerictory--------------------------
        Console.WriteLine("3.");
    

            file = File.ReadAllText("../../Trial.txt");

        Console.WriteLine(string.Join("->", lines));
        Console.WriteLine();

        //----------------HowToWriteInAFile-------------------
        Console.WriteLine("4.");

      //  File.WriteAllText( "Gorgon.txt", String.Join("|||", lines));

        Console.WriteLine(File.ReadAllText("Gorgon.txt"));

        File.WriteAllLines("Meduz.txt", file.Split());

        Console.WriteLine();

        Console.WriteLine(File.ReadAllText("Meduz.txt"));

        File.AppendAllText("Meduz.txt", "heymudi,rabagudi,olibaba,mamoktara");

        File.AppendAllLines("Gorgon.txt", "heymudi,rabagudi,olibaba,mamoktara".Split(','));

        //--------------CopyAProgramCode---------------

        var source = File.ReadAllLines("../../Syntax.cs");

        File.WriteAllLines("CopyOfSource.cs",source);

        //-----------------CopyAFile-------------------------

      //  File.Copy("CopyOfSource.cs","AnotherCopy.cs");

        //---------------IsThereAFile------------------

        Console.WriteLine(File.Exists("AnotherCopy.cs")); 




    }
}

