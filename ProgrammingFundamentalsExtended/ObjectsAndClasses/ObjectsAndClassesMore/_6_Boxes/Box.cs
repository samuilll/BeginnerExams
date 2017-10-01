using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Box
{
    public Point UpperLeft { get; set; }

    public Point UpperRight { get; set; }

    public Point BottomLeft { get; set; }

    public Point BottomRight { get; set; }

    public int Width
    {
        get
        {
            return Point.Distance(UpperLeft, UpperRight);
        }
    }
    public int Height
    {
        get
        {
            return Point.Distance(UpperLeft, BottomLeft);
        }
    }

    public static Box Parse(string input)
    {
        var currentBox = new Box();

        var separateNumbers = input
               .Split(new char[] { ' ', '{', '}', '|', ':' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

        for (int i = 0; i < separateNumbers.Length; i += 2)
        {
            var currentPoint = Point.Parse(separateNumbers[i], separateNumbers[i + 1]);

            switch (i)
            {
                case 0:
                    {
                        currentBox.UpperLeft = currentPoint;
                        break;
                    }
                case 2:
                    {
                        currentBox.UpperRight = currentPoint;
                        break;
                    }
                case 4:
                    {
                        currentBox.BottomLeft = currentPoint;
                        break;
                    }
                case 6:
                    {
                        currentBox.BottomRight = currentPoint;
                        break;
                    }
                default:
                    break;
            }

        }

        return currentBox;
    }

    public static int CalculatePerimeter(int width, int height)
    {
        return 2 * width + 2 * height;
    }

    public static int CalculateArea(int width, int height)
    {
        return width* height;
    }

}

