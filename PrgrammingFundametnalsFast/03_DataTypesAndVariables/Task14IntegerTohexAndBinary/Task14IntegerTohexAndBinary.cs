﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task14IntegerTohexAndBinary
    {
        static void Main(string[] args)
        {

        int number = int.Parse(Console.ReadLine());

        string hexNumber = Convert.ToString(number, 16).ToUpper();

        string binaryNumber = Convert.ToString(number, 2).ToUpper();

        Console.WriteLine(hexNumber);
        Console.WriteLine(binaryNumber);

            
        }
    }

