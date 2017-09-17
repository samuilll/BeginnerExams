using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//public class Point
//{
//    public double X { get; set; }

//    public double Y { get; set; }
//}


public class _4_DustanceBetweenPoints
    {
        static void Main(string[] args)
        {

            var firstPoint = ReadPoint();

            var secondPoint = ReadPoint();

            var distance = Distance(firstPoint, secondPoint);

            Console.WriteLine($"{distance:f3}");

        }

        public static Point  ReadPoint()
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

