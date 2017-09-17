using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class _3_EmployeeData
    {
        static void Main(string[] args)
        {

        var name = Console.ReadLine();

        var age = Console.ReadLine();

        var ID = int.Parse(Console.ReadLine());

        var salary = double.Parse(Console.ReadLine());

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Employee ID: {ID:D8}");
        Console.WriteLine($"Salary: {salary:f2}");



    }
}


//Name: Ivan
//Age: 24
//Employee ID: 00001192
//Salary: 1500.35