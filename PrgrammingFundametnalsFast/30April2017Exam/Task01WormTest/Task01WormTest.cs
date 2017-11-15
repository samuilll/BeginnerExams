using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class Task01WormTest
    {
        static void Main(string[] args)
        {

        long length = long.Parse(Console.ReadLine()) * 100;
        double width = double.Parse(Console.ReadLine());
     //   Console.WriteLine(length*width);

        var reminder = length % width;
        if (length ==0 || width==0)
        {
            Console.WriteLine("{0:f2}",0);
        }

       else if (reminder==0)
        {
            Console.WriteLine("{0:f2}", length * width);
        }
        else
        {
            Console.WriteLine("{0:f2}%", length * 100 / width);
        }

    }
}

