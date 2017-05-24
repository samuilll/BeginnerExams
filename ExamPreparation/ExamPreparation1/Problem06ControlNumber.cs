using System;

class Problem06ControlNumber
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int Control = int.Parse(Console.ReadLine());
        int Combnumber = 0;
        int Sum = 0;
        for (int i = 1; i <= N; i++)
        {
            for (int j = M; j > 0; j--)
            {
                if (Sum >= Control) break;               
                Combnumber++;
                var CurrentSum = i * 2 + j * 3;
                Sum = Sum + CurrentSum;

            }
          
        }
        if (Sum >= Control)
        {
            Console.WriteLine("{0} moves", Combnumber);
            Console.WriteLine("Score: {0} >= {1}", Sum, Control);
        }
        else
            Console.WriteLine("{0} moves", Combnumber);


    }
}

//Score: 117 >= 115