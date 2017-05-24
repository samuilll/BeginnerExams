using System;

	class magicnumbers06
	{
		static void Main(string[] args)
		{
		var n = int.Parse(Console.ReadLine());
		var dig1 = 0;
		var dig2 = 0;
		var dig3 = 0;
		var dig4 = 0;
		var dig5 = 0;
		var dig6 = 0;
		var umno = 0;
		for (int i =100000; i <= 999999; i++)
		{
			dig1 = i / 100000;
			dig2 = (i % 100000) / 10000;
			dig3 = ((i % 100000) % 10000) / 1000;
			dig4 = (((i % 100000) % 10000) % 1000) / 100;
			dig5 = ((((i % 100000) % 10000) % 1000) % 100)/10;
			dig6 = ((((i % 100000) % 10000) % 1000) % 100) % 10;
			umno = dig1 * dig2 * dig3 * dig4 * dig5 * dig6;
			if (umno == n)
				Console.Write(i + " ");			
		}
		Console.WriteLine();

	}
	}

