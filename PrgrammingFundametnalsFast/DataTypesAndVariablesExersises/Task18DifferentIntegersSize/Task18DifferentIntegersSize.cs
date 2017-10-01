using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task18DifferentIntegersSize
    {
        static void Main(string[] args)
        {

        string number = Console.ReadLine();

        bool[] types = new bool[7];

        string[] typeNames = new string[7] { "sbyte", "byte", "short" , "ushort", "int", "uint" ,"long" };

        bool sbyteCheck = sbyte.TryParse(number,out sbyte a);

        if (sbyteCheck)
        {
            types[0] = true;
        }

        bool byteCheck = byte.TryParse(number, out byte b);

        if (byteCheck)
        {
            types[1] = true;
        }

        bool shortCheck = short.TryParse(number, out short c);

        if (shortCheck)
        {
            types[2] = true;
        }

        bool ushortCheck = ushort.TryParse(number, out ushort d);

        if (ushortCheck)
        {
            types[3] = true;
        }

        bool intCheck = int.TryParse(number, out int e);

        if (intCheck)
        {
            types[4] = true;
        }


        bool uintCheck = uint.TryParse(number, out uint f);

        if (uintCheck)
        {
            types[5] = true;
        }

        bool longCheck = long.TryParse(number, out long g);

        if (longCheck)
        {
            types[6] = true;
        }

        if (types.Contains(true))
        {
            Console.WriteLine($"{number} can fit in:");
        }
        else
        {
            Console.WriteLine($"{number} can't fit in any type");

        }

        for (int i = 0; i < 7; i++)
        {
            if (types[i])
            {
                Console.WriteLine($"* {typeNames[i]}");
            }
        }
    }
}



//sbyte < byte < short < ushort < int < uint < long