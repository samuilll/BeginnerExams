using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task10CenturiesToNanoSeconds
    {
        static void Main(string[] args)
        {

        int centuries = int.Parse(Console.ReadLine());
        int years = centuries *100;
        int days = (int)Math.Floor((double)years * 365.2422);
        long hours = (long)days * 24;
        long minutes = hours * 60;
        ulong seconds = (ulong)minutes * 60;
        ulong miliSeconds = (ulong)seconds * 1000;
        ulong microSeconds = miliSeconds * 1000;
        decimal nanoSeconds = (decimal)microSeconds * 1000;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds}" +
            $" seconds = {miliSeconds} milliseconds = {microSeconds} microseconds = {nanoSeconds} nanoseconds");

        }
    }

