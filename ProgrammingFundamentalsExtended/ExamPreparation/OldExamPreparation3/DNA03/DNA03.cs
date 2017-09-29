using System;

class DNA03
{
    static void Main(string[] args)
    {
        var N = int.Parse(Console.ReadLine());
        var FirstLetter = char.Parse(Console.ReadLine());
        int PointNumber = 3;
        int LettersCount = 1;
        var Direction = "increasing";
        var CheckDirection = true;

        for (int i = 0; i < N; i++)
        {
            if (Direction == "increasing")
            {
                Console.Write("{0}", new string('.', PointNumber));
                for (int j = 0; j < LettersCount; j++)
                {
                    Console.Write(FirstLetter);
                    if (FirstLetter == 'G') { FirstLetter = 'A'; FirstLetter--; }
                    FirstLetter++;

                }
                Console.WriteLine("{0}", new string('.', PointNumber));
                PointNumber--;
                LettersCount += 2;
                if (LettersCount == 9) { LettersCount -= 4; PointNumber = 1; CheckDirection = false; }

            }

            if (Direction == "discreasing")
            {
                Console.Write("{0}", new string('.', PointNumber));
                for (int j = 0; j < LettersCount; j++)
                {
                    Console.Write(FirstLetter);
                    if (FirstLetter == 'G') { FirstLetter = 'A'; FirstLetter--; }
                    FirstLetter++;

                }
                Console.WriteLine("{0}", new string('.', PointNumber));
                PointNumber++;
                LettersCount -= 2;
                if (LettersCount == -1) { LettersCount += 2; PointNumber = 3; CheckDirection = true; }

            }
            if (CheckDirection) Direction = "increasing";
            else Direction = "discreasing";

        }

    }
}

