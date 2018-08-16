using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Phoenics
{
    public int BodyLength { get; set; }

    public decimal BodyWidth { get; set; }

    public int WingLength { get; set; }

    public Phoenics(int bodyL, decimal bodyW, int wingL)
    {
        this.BodyLength = bodyL;

        this.BodyWidth = bodyW;

        this.WingLength = wingL;
    }
}


class Program
{
    static void Main(string[] args)
    {

        var howManyInputs = int.Parse(Console.ReadLine());

        var phoenicsList = new List<Phoenics>();

        for (int i = 0; i < howManyInputs; i++)
        {
            var bodyLength = int.Parse(Console.ReadLine());

            var bodyWidth = decimal.Parse(Console.ReadLine());

            var wingLength = int.Parse(Console.ReadLine());

            var currentPhoenics = new Phoenics(bodyLength, bodyWidth, wingLength);

            phoenicsList.Add(currentPhoenics);
        }

        foreach (var phoenics in phoenicsList)
        {
            var time = CalculateTheTime(phoenics);

            Console.WriteLine(time);
        }
    }

    private static decimal CalculateTheTime(Phoenics phoenics)
    {
        var a = Convert.ToDecimal(Math.Pow(phoenics.BodyLength, 2));

        var b = Convert.ToDecimal(2*phoenics.WingLength + phoenics.BodyWidth);

        return a * b;
            }
}

