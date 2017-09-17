using System;

class Problem02Styrofoam
{
    static void Main(string[] args)
    {
        var Budget = double.Parse(Console.ReadLine());
        var HouseArea = double.Parse(Console.ReadLine());
        var WindowsNumber = int.Parse(Console.ReadLine());
        var PacketArea= double.Parse(Console.ReadLine());
        var PacketPrice= double.Parse(Console.ReadLine());
        var WorkArea = (HouseArea - WindowsNumber * 2.4) + 10 * (HouseArea - WindowsNumber * 2.4) / 100;
        var NessesaryPackets = Math.Ceiling(WorkArea / PacketArea);
        var AllPrice = NessesaryPackets * PacketPrice;
        var MoneyLeft = Budget - AllPrice;
        if(MoneyLeft>=0)
            Console.WriteLine("Spent: {0:f2}\nLeft: {1:f2}",AllPrice,MoneyLeft);
        else
            Console.WriteLine("Need more: {0:f2}",Math.Abs(MoneyLeft));
            


    }
}