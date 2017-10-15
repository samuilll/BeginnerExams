using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


    class Task03RegexMon
    {
        static void Main(string[] args)
        {

        string input = Console.ReadLine();

        Regex bojoRegex = new Regex(@"[A-Za-z]+-[A-Za-z]+");

        Regex didiRegex = new Regex(@"[^A-Za-z-]+");

        bool bojoTurn = false;

        bool didiTurn = true;

        while (didiTurn==true || bojoTurn==true)
        {
            if (didiTurn)
            {
                if (didiRegex.Match(input).Success)
                {
                    int didimatchIndex = didiRegex.Match(input).Index;

                    int didimatchLength = didiRegex.Match(input).Length;

                    string didiMatchString = didiRegex.Match(input).Value;

                    input = input.Substring(didimatchIndex+didimatchLength);

                    didiTurn = false;

                    bojoTurn = true;

                    Console.WriteLine(didiMatchString);
                }
                else
                {
                    didiTurn = false;
                }
               
            }
            if (bojoTurn)
            {
                if (bojoRegex.Match(input).Success)
                {
                    int bojomatchIndex = bojoRegex.Match(input).Index;

                    int bojomatchLength = bojoRegex.Match(input).Length;

                    string bojoMatchString = bojoRegex.Match(input).Value;

                    input = input.Substring(bojomatchIndex + bojomatchLength);

                    bojoTurn = false;

                    didiTurn = true;

                    Console.WriteLine(bojoMatchString);
                }
                else
                {
                    bojoTurn = false;
                }

            }
        }



    }
}

