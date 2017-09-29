using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_LambadaOneMoreDesicion
{
    class _5_LambadaOneMoreDesicion
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine()
                 .Split(new char[] { ' ', ' ', '.', '=', '>' }, StringSplitOptions.RemoveEmptyEntries);

            var register = new Dictionary<string, Dictionary<string, string>>();


            while (inputLine[0] != "lambada")
            {
                if (inputLine[0] != "dance")
                {
                    var selector = inputLine[0];

                    var Object = inputLine[1];

                    var property = inputLine[2];

                    FillTheDictionary(register, selector, Object, property);
                }
                else
                {
                    register = DanceTheRegister(register);
                }

                inputLine = Console.ReadLine()
                         .Split(new char[] { ' ', ' ', '.', '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            //   PrintTheResult(register);

            register
                .ToList()
                .ForEach(selector => selector.Value
                .ToList()
                .ForEach(objecto => Console.WriteLine("{0} => {1}.{2}"
                , selector.Key, objecto.Key, objecto.Value)));                


        } 

        private static Dictionary<string, Dictionary<string, string>> DanceTheRegister(Dictionary<string, Dictionary<string, string>> register)
        {
            return register
                .ToDictionary(selector => selector.Key, selector => selector.Value.ToDictionary
                  (n => n.Key, n => n.Key + "." + n.Value));
        }
        private static void FillTheDictionary(Dictionary<string, Dictionary<string, string>> register, string selector, string Object, string property)
        {
            if (!register.ContainsKey(selector))
            {
                register[selector] = new Dictionary<string, string>();
            }
            register[selector][Object] = property;
        }

        private static void PrintTheResult(Dictionary<string, Dictionary<string, string>> register)
        {
            foreach (var selector in register)
            {
                foreach (var pair in register[selector.Key])
                {
                    Console.WriteLine($"{pair.Key} => {pair.Key}.{pair.Value}");
                }
               
            }
        }
    }
}
