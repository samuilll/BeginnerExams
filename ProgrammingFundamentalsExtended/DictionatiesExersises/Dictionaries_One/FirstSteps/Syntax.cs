using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Syntax
    {
        static void Main()
        {
            var phonebook = new Dictionary<string, string>();

            phonebook["Ivan"] = "323 325 4325 4325";
            phonebook["Petur"] = "+213213 214324 23";
            phonebook["Alex"] = "*&(*&87*&987*&0987987";
            phonebook["Hibos"] = "213 213 2143 214";

            Console.WriteLine(phonebook.Count);

            var names = phonebook.Keys;

            var numbers = phonebook.Values;

            foreach (var item in phonebook)
            {
                var name = item.Key;

                var number = item.Value;

                Console.WriteLine($"{name} -> {number}");

            }
            Console.WriteLine();

         //   phonebook.Clear();

            phonebook.Add("Milko", "+0889 234 432");

            phonebook.Remove("Ivan");

         //   Console.WriteLine(phonebook["Ivan"]);

            foreach (var key in phonebook.Keys)
            {
                Console.WriteLine($"{key} -> {phonebook[key]}");

                Console.WriteLine("-------");
            }

            Console.WriteLine();

            var exist = phonebook.ContainsKey("Milko");

            Console.WriteLine(exist);

            Console.WriteLine();

            var existValue = phonebook.ContainsValue("+0889 234 432");

            Console.WriteLine(existValue);

            Console.WriteLine();

        var text = "1234";

        bool check = int.TryParse(text, out int parsedNumber);

        Console.WriteLine(parsedNumber+100);

        bool check2 = phonebook.TryGetValue("Milko", out string phoneNumber);

        Console.WriteLine(check2);

        Console.WriteLine(phoneNumber);

        var evenOrOdd = int.Parse(Console.ReadLine());

        var result = evenOrOdd % 2 == 0 ? "even" : "odd";

        Console.WriteLine(result);


    }
    }

