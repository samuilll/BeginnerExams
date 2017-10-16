using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03CirclesIntersection
{
    class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;

            this.Y = y;
        }

    }
    class Circle
    {
        public Point Center { get; set; }

        public double Radius { get; set; }

        public Circle(double x, double y, double r)
        {
            Point point = new Point(x, y);

            this.Center = point;

            this.Radius = r;
        }
    }
    class Task03CirclesIntersection
    {
        static void Main(string[] args)
        {

            var firstInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var firstCircle = new Circle(double.Parse(firstInput[0]), double.Parse(firstInput[1]), double.Parse(firstInput[2]));

            var secondInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var secondCircle = new Circle(double.Parse(secondInput[0]), double.Parse(secondInput[1]), double.Parse(secondInput[2]));

            var distance = CalculateTheDistance(firstCircle.Center,secondCircle.Center);

            if (distance<=firstCircle.Radius+secondCircle.Radius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static double CalculateTheDistance(Point center1, Point center2)
        {
            return Math.Sqrt((center1.X-center2.X)* (center1.X - center2.X)+ (center1.Y - center2.Y)*(center1.Y - center2.Y));        }
    }
}
