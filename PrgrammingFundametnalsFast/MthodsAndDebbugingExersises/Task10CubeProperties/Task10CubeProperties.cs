using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task10CubeProperties
    {
        static void Main(string[] args)
        {

        double cubeEdge = Double.Parse(Console.ReadLine());

        string kindOfFormula = Console.ReadLine();

        double searchedCalculation = 0;

        switch (kindOfFormula)
        {
            case "face":
                {
                    searchedCalculation = FaceFormula(cubeEdge);
                    break;
                }
            case "space":
                {
                    searchedCalculation = SpaceFormula(cubeEdge);
                    break;
                }
            case "volume":
                {
                    searchedCalculation = VolumeFormula(cubeEdge);
                    break;
                }
            case "area":
                {
                    searchedCalculation = AreaFormula(cubeEdge);
                    break;
                }
        }

        Console.WriteLine($"{searchedCalculation:f2}");
    }

    private static double AreaFormula(double cubeEdge)
    {
        return 6 * cubeEdge * cubeEdge;    }

    private static double VolumeFormula(double cubeEdge)
    {
        return Math.Pow(cubeEdge,3);    }

    private static double SpaceFormula(double cubeEdge)
    {
        return Math.Sqrt(3 * cubeEdge * cubeEdge);
    }

    private static double FaceFormula(double cubeEdge)
    {
        return Math.Sqrt(2*cubeEdge*cubeEdge);
    }
}

