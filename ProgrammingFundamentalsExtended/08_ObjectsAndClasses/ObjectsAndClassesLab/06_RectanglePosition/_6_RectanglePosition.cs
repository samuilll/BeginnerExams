using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rectangle
{
    public double Left { set; get; }
    public double Top { set; get; }
    public double Width { set; get; }
    public double Height { set; get; }
    public double Right
    {
        get
        {
            return Left + Width;
        }
    }
    public double Bottom
    {
        get
        {
            return Top + Height;
        }
    }


}
class _6_RectanglePosition
{
    static void Main(string[] args)
    {
        var firstRectangle = ReadTheRectangle();

        var secondRectangle = ReadTheRectangle();

        var isInside = CheckTheRectangles(firstRectangle, secondRectangle);

        Console.WriteLine(isInside ? "Inside":"Not inside");
    }

    private static bool CheckTheRectangles(Rectangle firstRectangle, Rectangle secondRectangle)
    {
        if (firstRectangle.Left >= secondRectangle.Left && firstRectangle.Right <= secondRectangle.Right
            && firstRectangle.Top <= secondRectangle.Top && firstRectangle.Bottom <= secondRectangle.Bottom)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static Rectangle ReadTheRectangle()
    {
        var Rec = new Rectangle();
        var parameters = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

        Rec.Left = parameters[0];
        Rec.Top = parameters[1];
        Rec.Width = parameters[2];
        Rec.Height = parameters[3];

        return Rec;

    }
}

