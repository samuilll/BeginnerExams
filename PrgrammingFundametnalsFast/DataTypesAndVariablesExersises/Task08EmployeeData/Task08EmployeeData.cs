using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task08EmployeeData
    {
        static void Main(string[] args)
        {
        string firstName = Console.ReadLine();
        string lastname = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        long id = long.Parse(Console.ReadLine());
        long uniqueNumber = long.Parse(Console.ReadLine());

        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Last name: {lastname}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Personal ID: {id}");
        Console.WriteLine($"Unique Employee number: {uniqueNumber}");

    }
}
//First name: Amanda
//Last name: Jonson
//Age: 27
//Gender: f
//Personal ID: 8306112507
//Unique Employee number: 27563571
