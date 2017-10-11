using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task07BombNumber
    {
        static void Main(string[] args)
        {

        var sequence = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var bombParams = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);

        var bombNumber = int.Parse(bombParams[0]);

        var bombPower = int.Parse(bombParams[1]);

        for (int i = 0; i < sequence.Count; i++)
        {
            if (sequence[i] == bombNumber)
            {
                for (int j = i-1,p=0; p < bombPower && j>=0; j--,p++)
                {
                    sequence.RemoveAt(j);
                }
                for (int j = sequence.IndexOf(bombNumber),p=0; p <= bombPower && j<sequence.Count; p++)
                {
                    sequence.RemoveAt(j);
                }
                i=-1;
            }
        }

      //   Console.WriteLine(string.Join(" ",sequence));
        
            Console.WriteLine(sequence.Sum());
        

    }
    }

