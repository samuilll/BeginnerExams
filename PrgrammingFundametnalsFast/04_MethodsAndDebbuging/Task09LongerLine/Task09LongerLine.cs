using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task09LongerLine
    {
        static void Main(string[] args)
        {
        double firstX = double.Parse(Console.ReadLine());
        double firstY = double.Parse(Console.ReadLine());
        double secondX = double.Parse(Console.ReadLine());
        double secondY = double.Parse(Console.ReadLine());
        double thirdX = double.Parse(Console.ReadLine());
        double thirdY = double.Parse(Console.ReadLine());
        double fourthX = double.Parse(Console.ReadLine());
        double fourthY = double.Parse(Console.ReadLine());

        double firstLength = FindTheLength(firstX,firstY,secondX,secondY);

        double secondLength = FindTheLength(thirdX, thirdY, fourthX, fourthY);

        if (firstLength>=secondLength)
        {
            Console.WriteLine($"{CalculateTheShortestDistance(firstX, firstY, secondX, secondY)}" +
                $"{CalculateTheLongesttDistance(firstX, firstY, secondX, secondY)}");
        }
        else
        {
            Console.WriteLine($"{CalculateTheShortestDistance(thirdX, thirdY, fourthX, fourthY)}" +
               $"{CalculateTheLongesttDistance(thirdX, thirdY, fourthX, fourthY)}");
        }


    }

    private static double FindTheLength(double firstX, double firstY, double secondX, double secondY)
    {

        return Math.Sqrt(Math.Pow((firstX -secondX),2) + Math.Pow(firstY - secondY,2));
    }

    private static string CalculateTheShortestDistance(double firstX, double firstY, double secondX, double secondY)
    {
        double firstDistance = Math.Sqrt((double)Math.Pow(firstX, 2) +(double) Math.Pow(firstY, 2));

        double secondDistance = Math.Sqrt((double)Math.Pow(secondX, 2) + (double)Math.Pow(secondY, 2));

        if (firstDistance <= secondDistance)
        {
            return $"({firstX}, {firstY})";
        }
        else
        {
            return $"({secondX}, {secondY})";

        }

    }

    private static string CalculateTheLongesttDistance(double firstX, double firstY, double secondX, double secondY)
    {
        double firstDistance = Math.Sqrt((double)Math.Pow(firstX, 2) + (double)Math.Pow(firstY, 2));

        double secondDistance = Math.Sqrt((double)Math.Pow(secondX, 2) + (double)Math.Pow(secondY, 2));

        if (firstDistance > secondDistance)
        {
            return $"({firstX}, {firstY})";
        }
        else
        {
            return $"({secondX}, {secondY})";

        }

    }
}

