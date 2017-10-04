using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task11GeometryCalculator
    {
        static void Main(string[] args)
        {

        string kindOfFigure = Console.ReadLine();

        double area = 0;

        switch (kindOfFigure)
        {
            case "triangle":
                {
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    area = TriangleArea(side,height);
                    break;
                }

            case "circle":
                {
                    double radius = double.Parse(Console.ReadLine());
                    area = CircleArea(radius);
                    break;
                }

            case "square":
                {
                    double side = double.Parse(Console.ReadLine());
                    area = SquareArea(side);
                    break;
                }

            case "rectangle":
                {
                    double width = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    area = RectangleArea(width,height);
                    break;
                }
        }

        Console.WriteLine($"{area:f2}");
    }

    private static double RectangleArea(double width, double height)
    {
        return width * height;    }

    private static double SquareArea(double side)
    {
        return side * side;    }

    private static double CircleArea(double radius)
    {
        return Math.PI * radius * radius;    }

    private static double TriangleArea(double side, double height)
    {
        return (side * height) / 2;    }
}

