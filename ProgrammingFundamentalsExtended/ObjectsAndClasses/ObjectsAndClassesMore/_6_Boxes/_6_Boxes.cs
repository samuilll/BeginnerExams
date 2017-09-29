using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Point
{
    public int X { get; set; }

    public int Y { get; set; }

    public static int Distance(Point firstPoint, Point secondPoint)
    {
        var current = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
        return Convert.ToInt32(current);
    }

    public static Point Parse(int one, int two)
    {
        var currentPoint = new Point();

        currentPoint.X = one;

        currentPoint.Y = two;

        return currentPoint;
    }
}


class _6_Boxes
    {
        static void Main(string[] args)
        {
        var input = Console.ReadLine();

        var boxesList = new List<Box>();

        while (input!="end")
        {
            var currentBox = Box.Parse(input);

            boxesList.Add(currentBox);

            input = Console.ReadLine();
        }

        foreach (var box in boxesList)
        {
            Console.WriteLine($"Box: {box.Width}, {box.Height}");

            Console.WriteLine($"Perimeter: {Box.CalculatePerimeter(box.Width,box.Height)}");

            Console.WriteLine($"Area: {Box.CalculateArea(box.Width, box.Height)}");
        }
        }
    }

