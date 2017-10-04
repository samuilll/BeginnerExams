using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Task08CentralPodouble
    {
        static void Main(string[] args)
        {

        double firstX = double.Parse(Console.ReadLine());
        double firstY = double.Parse(Console.ReadLine());
        double secondX = double.Parse(Console.ReadLine());
        double secondY = double.Parse(Console.ReadLine());

        string theNearestPodoubleCoordinates = CalculateTheShortestDistance(firstX,firstY,secondX,secondY);

        Console.WriteLine(theNearestPodoubleCoordinates);


    }

    private static string CalculateTheShortestDistance(double firstX, double firstY, double secondX, double secondY)
    {
        double firstDistancePow = Math.Pow(firstX, 2) + Math.Pow(firstY, 2);

        double secondDistancePow = Math.Pow(secondX, 2) + Math.Pow(secondY, 2);

        if (firstDistancePow<=secondDistancePow)
        {
            return $"({firstX}, {firstY})";
        }
        else
        {
            return $"({secondX}, {secondY})";

        }

    }
}


