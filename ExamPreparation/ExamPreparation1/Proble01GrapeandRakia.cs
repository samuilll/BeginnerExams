using System;

    class Proble01GrapeandRakia
    {
        static void Main(string[] args)
        {
        var area = double.Parse(Console.ReadLine());
        var kilos = double.Parse(Console.ReadLine());
        var waste = double.Parse(Console.ReadLine());
        var grapekilos = kilos * area - waste;
        double rakialiters = (45 * grapekilos / 100) / 7.5;
        var grapeforsale = 55 * grapekilos / 100;
        double rakiaprofit = rakialiters * 9.8;
        double grapeprofit = grapeforsale * 1.5;
        Console.WriteLine("{0:f2}",rakiaprofit);
        Console.WriteLine("{0:f2}",grapeprofit,2);



    }
}

