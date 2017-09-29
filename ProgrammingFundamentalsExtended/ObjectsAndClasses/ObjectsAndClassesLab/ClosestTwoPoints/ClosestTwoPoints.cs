using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Point
{
    public double X { get; set; }

    public double Y { get; set; }

    private static double Distance(Point firstPoint, Point secondPoint)
    {
        return Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
    }
}


class ClosestTwoPoints
{
    static void Main(string[] args)
    {

        var numberOfPoints = int.Parse(Console.ReadLine());

        var pointsList = new List<Point>();

        for (int i = 0; i < numberOfPoints; i++)
        {
            var currentPoint = ReadPoint();

            pointsList.Add(currentPoint);
        }

        var equals = FindTheMinDistance(pointsList);

        var distance = Distance(equals[0],equals[1]);

        Console.WriteLine($"{distance:f3}");

        foreach (var point in equals)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }

       
    }

    private static List<Point> FindTheMinDistance(List<Point> pointsList)
    {
        var minDistance = double.MaxValue;

        var firsPoint = new Point();

        var secondPoint = new Point();

        var list = new List<Point>();

        for (int i = 0; i < pointsList.Count - 1; i++)
        {
            for (int j = i + 1; j < pointsList.Count; j++)
            {
                var currentDistance = Distance(pointsList[i],pointsList[j]);

                var currentFisrstPoint = pointsList[i];

                var currentSecondPoint = pointsList[j];

                if (minDistance>currentDistance)
                {
                    minDistance = currentDistance;

                    firsPoint = currentFisrstPoint;

                    secondPoint = currentSecondPoint;
                }
            }
        }
      

            list.Add(firsPoint);

            list.Add(secondPoint);

            return list;
               
    }

    public static Point ReadPoint()
    {
        var Coordinates = Console.ReadLine()
                       .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                       .Select(int.Parse)
                       .ToArray();

        return new Point
        {
            X = Coordinates[0],
            Y = Coordinates[1]
        };
    }

    private static double Distance(Point firstPoint, Point secondPoint)
    {
        return Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
    }
}

