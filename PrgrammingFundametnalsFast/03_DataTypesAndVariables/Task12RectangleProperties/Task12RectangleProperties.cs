﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task12RectangleProperties
    {
        static void Main(string[] args)
        {

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double perimeter = 2 * a + 2 * b;
        double area = a * b;
        double diagonal = Math.Sqrt(a*a+b*b);

        Console.WriteLine($"{perimeter}\n{area}\n{diagonal}");

    }
}

