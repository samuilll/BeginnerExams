using System;

    class Problem04Bills
    {
    static void Main(string[] args)
    {
        var months = int.Parse(Console.ReadLine());
        var Eletricitybill = 0.0;
        var otherbills = 0.0;
        var waterbill = 0.0;
        var netbill = 0.0;
        var allbills = 0.0;
        for (int i = 0; i < months; i++)
        {
            var electricbill = double.Parse(Console.ReadLine());
            Eletricitybill = Eletricitybill + electricbill;
            double otherbillnow = (electricbill + 15 + 20) + 20 * (electricbill + 15 + 20) / 100;
            otherbills = otherbills + otherbillnow;
            waterbill = waterbill + 20;
            netbill = netbill + 15;
            double all = electricbill + otherbillnow + 15 + 20;
            allbills = allbills + all;
        }
        Console.WriteLine("Electricity: {0:f2} lv", Eletricitybill);
        Console.WriteLine("Water: {0:f2} lv", waterbill);
        Console.WriteLine("Internet: {0:f2} lv", netbill);
        Console.WriteLine("Other: {0:f2} lv", otherbills);
        Console.WriteLine("Average: {0:f2} lv",allbills/months);




    }
}

