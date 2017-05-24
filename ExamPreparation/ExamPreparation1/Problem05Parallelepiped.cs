using System;

    class Problem05Parallelepiped
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());
        int leftside = 0;
        int middleside = n - 2;
        int rightside = 3*n+1-(leftside+middleside+3);
        Console.WriteLine("+{1}+{0}",new string('.', 3 * n + 1 - (middleside + 2)),new string('~',middleside));
        for (int i = 0; i < 2*n+1; i++)
        {
            Console.WriteLine($"|{new string('.',leftside)}\\{new string('~',middleside)}\\{new string('.',rightside)}");
            leftside++;
            rightside--;

        }
        rightside = leftside-1;
        leftside = 0;

        for (int i = 0; i < 2*n+1; i++)
        {
            Console.WriteLine($"{new string('.', leftside)}\\{new string('.', rightside)}|{new string('~', middleside)}|");
            leftside++;
            rightside--;
        }
        Console.WriteLine("{0}+{1}+", new string('.', 3*n+1-(middleside+2)), new string('~', middleside));
    }
}

//+~~~+...........
//|\~~~\..........
//|.\~~~\.........       
//|..\~~~\........
//|...\~~~\.......
//|....\~~~\......
//|.....\~~~\.....
//|......\~~~\....
//|.......\~~~\...
//|........\~~~\..
//|.........\~~~\.
//|..........\~~~\
//\..........|~~~|
//.\.........|~~~|
//..\........|~~~|
//...\.......|~~~|
//....\......|~~~|
//.....\.....|~~~|
//......\....|~~~|
//.......\...|~~~|
//........\..|~~~|
//.........\.|~~~|
//..........\|~~~|
//...........+~~~+
