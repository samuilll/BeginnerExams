using System;

    class PoolPipes02
    {
        static void Main(string[] args)
        {

            var Vpool = int.Parse(Console.ReadLine());
            var debit1 = int.Parse(Console.ReadLine());
            var debit2 = int.Parse(Console.ReadLine());
            var time = float.Parse(Console.ReadLine());
            var V1 = time * debit1;
            var V2 = time * debit2;
            if ((V1 + V2) <= Vpool)
                Console.WriteLine(" The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", (int)((V1 + V2) * 100 / Vpool), (int)(V1 * 100 / (V1 + V2)), (int)(V2 * 100 / (V1 + V2)));
            else
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", time, (float)(V1 + V2 - Vpool));
        }
    }


//The pool is 66% full. Pipe 1: 45%. Pipe 2: 54%.  

//2.5	For 2.5 hours the pool overflows with 400 liters.	
	 

