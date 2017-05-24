using System;

    class DNA03
    {
        static void Main(string[] args)
        {
        var N = int.Parse(Console.ReadLine());
        var FirstLetter = char.Parse(Console.ReadLine());
        char[] Letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
        int FirstLetterPLaceInLetters=0;
        int PointNumber = 3;
        for (int i = 0; i < Letters.Length; i++)
        {
            if (Letters[i] == FirstLetter) FirstLetterPLaceInLetters = i;

        }
        for (int i = 0; i < N; i++)
        {


            Console.Write("{0}",new string('.',PointNumber));
            
        }
        }
    }

